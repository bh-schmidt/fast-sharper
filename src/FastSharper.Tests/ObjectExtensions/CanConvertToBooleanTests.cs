using NUnit.Framework;

namespace FastSharper.Tests
{
    public class CanConvertToBooleanTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            bool value = true;
            Assert.IsTrue(value.CanConvertToBoolean());
        }

        [Test]
        public void Will_return_true_because_the_object_can_be_converted()
        {
            var value = "true";
            Assert.IsTrue(value.CanConvertToBoolean());
        }

        [Test]
        public void Will_return_false_because_the_conversion_is_invalid()
        {
            var value = "text";
            Assert.IsFalse(value.CanConvertToBoolean());
        }
    }
}
