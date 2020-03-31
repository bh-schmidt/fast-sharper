using NUnit.Framework;

namespace FastSharper.Tests
{
    public class IsValidTests : BaseTests
    {
        [Test]
        public void Will_return_true()
        {
            var value = TestEnum.VALUE;

            Assert.IsTrue(value.IsValid());
        }

        [Test]
        public void Will_return_false()
        {
            var value = (TestEnum)2;

            Assert.IsFalse(value.IsValid());
        }
    }
}
