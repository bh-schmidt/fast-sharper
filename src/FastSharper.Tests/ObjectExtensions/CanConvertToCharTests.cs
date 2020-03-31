using NUnit.Framework;

namespace FastSharper.Tests
{
    public class CanConvertToCharTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            char value = 'A';
            Assert.IsTrue(value.CanConvertToChar());
        }

        [Test]
        public void Will_return_true_because_the_object_can_be_converted()
        {
            var value = "A";
            Assert.IsTrue(value.CanConvertToChar());
        }

        [Test]
        public void Will_return_false_because_the_conversion_is_invalid()
        {
            var value = "text";
            Assert.IsFalse(value.CanConvertToChar());
        }
    }
}
