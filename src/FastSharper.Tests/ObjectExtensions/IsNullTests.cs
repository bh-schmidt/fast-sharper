using NUnit.Framework;

namespace FastSharper.Tests
{
    public class IsNullTests : BaseTests
    {
        [Test]
        public void Will_return_true()
        {
            object? obj = null;

            Assert.IsTrue(obj.IsNull());
        }

        [Test]
        public void Will_return_false()
        {
            string value = string.Empty;

            Assert.IsFalse(value.IsNull());
        }
    }
}
