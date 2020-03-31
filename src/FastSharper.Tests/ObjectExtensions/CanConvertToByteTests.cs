using NUnit.Framework;

namespace FastSharper.Tests
{
    public class CanConvertToByteTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            byte value = 255;
            Assert.IsTrue(value.CanConvertToByte());
        }

        [Test]
        public void Will_return_true_because_the_object_can_be_converted()
        {
            var value = "255";
            Assert.IsTrue(value.CanConvertToByte());
        }

        [Test]
        public void Will_return_false_because_the_conversion_is_invalid()
        {
            var value = "text";
            Assert.IsFalse(value.CanConvertToByte());
        }
    }
}
