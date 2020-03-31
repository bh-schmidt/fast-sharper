using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper.Tests
{
    public class IsNullOrEmptyTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_is_null()
        {
            IEnumerable<object>? enumerable = null;

            Assert.IsTrue(enumerable.IsNullOrEmpty());
        }

        [Test]
        public void Will_return_true_because_is_empty()
        {
            var enumerable = Enumerable.Empty<object>();

            Assert.IsTrue(enumerable.IsNullOrEmpty());
        }

        [Test]
        public void Will_return_false_because_the_array_is_not_empty()
        {
            var array = new[] { 1, 2, 3 };

            Assert.IsFalse(array.IsNullOrEmpty());
        }
    }
}
