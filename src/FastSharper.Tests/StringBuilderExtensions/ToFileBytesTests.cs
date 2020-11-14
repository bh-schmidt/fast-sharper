using NUnit.Framework;
using System.Linq;
using System.Text;

namespace FastSharper.Tests.StringBuilderExtensions
{
    public class ToFileBytesTests : BaseTests
    {
        [Test]
        public void Will_return_the_bytes()
        {
            var src = new StringBuilder("123");
            var bytes = src.ToFileBytes();
            Assert.True(bytes.Any());
        }
    }
}
