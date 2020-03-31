using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToInt64Tests : BaseTests
    {
        [Test]
        public void Will_convert_to_Int64()
        {
            var value = "1200";
            Assert.AreEqual(1200, value.ToInt64());
        }
    }
}
