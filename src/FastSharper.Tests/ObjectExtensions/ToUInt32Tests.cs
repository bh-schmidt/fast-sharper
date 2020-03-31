using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToUInt32Tests : BaseTests
    {
        [Test]
        public void Will_convert_to_UInt32()
        {
            var value = "1200";
            Assert.AreEqual(1200, value.ToUInt32());
        }
    }
}
