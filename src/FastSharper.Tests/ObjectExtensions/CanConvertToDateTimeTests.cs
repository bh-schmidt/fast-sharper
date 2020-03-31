using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class CanConvertToDateTimeTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            DateTime value = DateTime.Now;
            Assert.IsTrue(value.CanConvertToDateTime());
        }

        [Test]
        public void Will_return_true_because_the_object_can_be_converted()
        {
            var value = "2020-02-15";
            Assert.IsTrue(value.CanConvertToDateTime());
        }

        [Test]
        public void Will_return_false_because_the_conversion_is_invalid()
        {
            var value = "text";
            Assert.IsFalse(value.CanConvertToDateTime());
        }
    }
}
