using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToSingleTests : BaseTests
    {
        [Test]
        public void Will_convert_to_Single()
        {
            var value = "1200";
            Assert.AreEqual(1200F, value.ToSingle());
        }
    }
}
