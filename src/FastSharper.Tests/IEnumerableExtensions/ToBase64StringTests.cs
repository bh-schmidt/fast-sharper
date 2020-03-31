using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ToBase64StringTests : BaseTests
    {
        [Test]
        public void ToBase64String()
        {
            byte[] value = new byte[] { 115, 245, 55, 95, 254, 157, 122, 168, 36, 51 };

            Assert.AreEqual("c/U3X/6deqgkMw==", value.ToBase64String());
        }

        [Test]
        public void Will_return_an_empty_string_because_the_array_is_empty()
        {
            byte[] numbers = Array.Empty<byte>();

            Assert.AreEqual("", numbers.ToBase64String());
        }

        [Test]
        public void Will_throw_exception_because_the_array_is_null()
        {
            byte[] bytes = null!;

            Assert.Catch<ArgumentNullException>(() => bytes.ToBase64String());
        }
    }
}
