using NUnit.Framework;

namespace FastSharper.Tests
{
    public class ToInt16Tests : BaseTests
    {
        [Test]
        public void Will_convert_to_Int16()
        {
            var value = "250";
            Assert.AreEqual(250, value.ToInt16());
        }
    }
}
