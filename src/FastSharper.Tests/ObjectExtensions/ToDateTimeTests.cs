using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToDateTimeTests : BaseTests
    {
        [Test]
        public void Will_convert_to_DateTime()
        {
            var value = "2020-02-15";
            var date = value.ToDateTime();

            Assert.AreEqual(2020, date.Year);
            Assert.AreEqual(02, date.Month);
            Assert.AreEqual(15, date.Day);
        }
    }
}
