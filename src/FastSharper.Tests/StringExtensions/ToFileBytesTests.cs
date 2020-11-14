using NUnit.Framework;
using System.Linq;

namespace FastSharper.Tests.StringExtensions
{
    public class ToFileBytesTests : BaseTests
    {
        [Test]
        public void Will_return_the_bytes()
        {
            var src = "123";
            var bytes = src.ToFileBytes();
            Assert.True(bytes.Any());
        }
    }
}
