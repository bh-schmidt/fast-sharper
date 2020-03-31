using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ToTests : BaseTests
    {
        [Test]
        public void Will_convert_the_value()
        {
            var source = int.MaxValue;

            var conversion = source.To<long>();

            Assert.AreEqual(source, conversion);
        }

        [Test]
        public void Will_throw_exception_because_its_an_impossible_conversion()
        {
            var source = "text";

            Assert.Catch<Exception>(() => source.To<int>());
        }

        [Test]
        public void Will_throw_exception_because_the_source_is_null()
        {
            string source = null!;

            Assert.Catch<ArgumentNullException>(() => source.To<int>());
        }
    }
}
