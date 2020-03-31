using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToDecimalTests : BaseTests
    {
        [Test]
        public void Will_convert_to_Decimal()
        {
            var value = "1250.50";
            Assert.AreEqual(1250.5M, value.ToDecimal());
        }
    }
}
