using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToSByteTests : BaseTests
    {
        [Test]
        public void Will_convert_to_SByte()
        {
            var value = "48";
            Assert.AreEqual(48, value.ToSByte());
        }
    }
}
