using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ReplaceWithRegexTests : BaseTests
    {
        [Test]
        public void Will_replace_the_comma()
        {
            string source = "123,456";
            string regexPattern = "[,]";
            string replacement = "";

            Assert.AreEqual("123456", source.ReplaceWithRegex(regexPattern, replacement));
        }

        [Test]
        public void Will_throw_source_is_null()
        {
            string source = null!;
            string regexPattern = "[,]";
            string replacement = "";

            Assert.Catch<ArgumentNullException>(() => source.ReplaceWithRegex(regexPattern, replacement));
        }

        [Test]
        public void Will_throw_pattern_is_null()
        {
            string source = "123,456";
            string regexPattern = null!;
            string replacement = "";

            Assert.Catch<ArgumentNullException>(() => source.ReplaceWithRegex(regexPattern, replacement));
        }

        [Test]
        public void Will_return_replacement_is_null()
        {
            string source = "123,456";
            string regexPattern = "[,]";
            string replacement = null!;

            Assert.Catch<ArgumentNullException>(() => source.ReplaceWithRegex(regexPattern, replacement));
        }
    }
}
