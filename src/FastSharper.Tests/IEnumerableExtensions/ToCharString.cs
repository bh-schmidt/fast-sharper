using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ToCharString : BaseTests
    {
        [Test]
        public void Will_convert_the_chars_to_the_specific_string()
        {
            var chars = new[] { 'a', 'b', 'c', 'd', 'e' };

            Assert.AreEqual("abcde", chars.ToCharString());
        }

        [Test]
        public void Will_return_an_empty_string_because_the_array_is_empty()
        {
            char[] chars = Array.Empty<char>();

            Assert.AreEqual("", chars.ToCharString());
        }

        [Test]
        public void Will_throw_exception_because_the_array_is_null()
        {
            char[] chars = null!;

            Assert.Catch<ArgumentNullException>(() => chars.ToCharString());
        }
    }
}
