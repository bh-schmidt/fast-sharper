using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToCharTests : BaseTests
    {
        [Test]
        public void Will_convert_to_Char()
        {
            var value = "A";
            Assert.AreEqual('A', value.ToChar());
        }
    }
}
