using NUnit.Framework;

namespace FastSharper.Tests
{
    public class CanConvertToStringTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_type_is_equal()
        {
            var value = string.Empty;
            Assert.IsTrue(value.CanConvertToString());
        }
    }
}
