using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToByteTests : BaseTests
    {
        [Test]
        public void Will_converto_to_Byte()
        {
            var value = true;
            Assert.AreEqual(1, value.ToByte());
        }
    }
}
