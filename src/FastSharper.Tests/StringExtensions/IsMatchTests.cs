using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsMatchTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_pattern_matches_with_the_input()
        {
            string source = "abcde";
            string pattern = "[a-zA-Z]";

            Assert.IsTrue(source.IsMatch(pattern));
        }

        [Test]
        public void Will_return_false_because_the_pattern_does_not_matches_with_the_input()
        {
            string source = "12345";
            string pattern = "[a-zA-Z]";

            Assert.IsFalse(source.IsMatch(pattern));
        }

        [Test]
        public void Will_throw_source_is_null()
        {
            string source = null!;
            string pattern = "[a-zA-Z]";

            Assert.Catch<ArgumentNullException>(() => source.IsMatch(pattern));
        }

        [Test]
        public void Will_throw_pattern_is_null()
        {
            string source = "12345";
            string pattern = null!;

            Assert.Catch<ArgumentNullException>(() => source.IsMatch(pattern));
        }
    }
}
