using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToDoubleTests : BaseTests
    {
        [Test]
        public void Will_convert_to_Double()
        {
            var value = "1000.50";
            Assert.AreEqual(1000.50D, value.ToDouble());
        }
    }
}
