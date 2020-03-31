using NUnit.Framework;
using System.Linq;

namespace FastSharper.Tests
{
    public class IsEmpty : BaseTests
    {
        [Test]
        public void Will_return_true_because_is_empty()
        {
            var array = Enumerable.Empty<object>();

            Assert.IsTrue(array.IsEmpty());
        }

        [Test]
        public void Will_return_false_because_is_not_empty()
        {
            var array = new[] { 1, 2 };

            Assert.IsFalse(array.IsEmpty());
        }
    }
}
