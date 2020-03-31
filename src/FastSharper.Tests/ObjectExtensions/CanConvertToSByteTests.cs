using NUnit.Framework;

namespace FastSharper.Tests
{
    public class CanConvertToSByteTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            sbyte value = 127;
            Assert.IsTrue(value.CanConvertToSByte());
        }

        [Test]
        public void Will_return_true_because_the_object_can_be_converted()
        {
            var value = "127";
            Assert.IsTrue(value.CanConvertToSByte());
        }

        [Test]
        public void Will_return_false_because_the_conversion_is_invalid()
        {
            var value = "text";
            Assert.IsFalse(value.CanConvertToSByte());
        }
    }
}
