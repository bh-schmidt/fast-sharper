using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToUInt64Tests : BaseTests
    {
        [Test]
        public void Will_convert_to_UInt64()
        {
            var value = "1200";
            Assert.AreEqual(1200, value.ToUInt64());
        }
    }
}
