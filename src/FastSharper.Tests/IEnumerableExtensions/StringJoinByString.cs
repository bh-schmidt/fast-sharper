using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class StringJoinByString
    {
        [Test]
        public void Will_return_numbers_separated_by_comma()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual("1,2,3,4,5", numbers.StringJoinBy(","));
        }

        [Test]
        public void Will_return_an_empty_string_because_the_array_is_empty()
        {
            int[] numbers = Array.Empty<int>();

            Assert.AreEqual("", numbers.StringJoinBy(","));
        }

        [Test]
        public void Will_throw_exception_because_the_array_is_null()
        {
            int[] numbers = null!;

            Assert.Catch<ArgumentNullException>(() => numbers.StringJoinBy(","));
        }
    }
}
