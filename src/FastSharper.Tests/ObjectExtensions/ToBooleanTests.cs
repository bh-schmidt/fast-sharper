using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToBooleanTests : BaseTests
    {
        [Test]
        public void Will_convert_to_Boolean()
        {
            int obj = 1;
            Assert.IsTrue(obj.ToBoolean());
        }
    }
}
