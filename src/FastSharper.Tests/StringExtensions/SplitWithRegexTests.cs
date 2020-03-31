using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class SplitWithRegexTests : BaseTests
    {
        [Test]
        public void Will_split_the_string()
        {
            string source = "123,456";
            string regexPattern = "[,]";

            Assert.AreEqual(new[] { "123", "456" }, source.SplitWithRegex(regexPattern));
        }

        [Test]
        public void Will_not_split_because_the_pattern_doesnt_match()
        {
            string source = "123.456";
            string regexPattern = "[,]";

            Assert.AreEqual(new[] { "123.456" }, source.SplitWithRegex(regexPattern));
        }

        [Test]
        public void Will_throw_source_is_null()
        {
            string source = null!;
            string regexPattern = "[,]";

            Assert.Catch<ArgumentNullException>(() => source.SplitWithRegex(regexPattern));
        }

        [Test]
        public void Will_throw_pattern_is_null()
        {
            string source = "123.456";
            string regexPattern = null!;

            Assert.Catch<ArgumentNullException>(() => source.SplitWithRegex(regexPattern));
        }
    }
}
