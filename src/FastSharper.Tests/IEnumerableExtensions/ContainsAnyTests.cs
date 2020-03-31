using NUnit.Framework;
using System.Linq;

namespace FastSharper.Tests
{
    public class ContainsAnyTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_comparison_is_empty()
        {
            var comparison = Enumerable.Empty<int>();
            var source = Enumerable.Empty<int>();

            Assert.IsTrue(source.ContainsAny(comparison));
        }

        [Test]
        public void Will_return_false_because_source_is_empty()
        {
            var comparison = new[] { 1, 2, 3 };
            var source = Enumerable.Empty<int>();

            Assert.IsFalse(source.ContainsAny(comparison));
        }

        [Test]
        public void Will_return_true_because_the_comparison_values_are_in_the_source()
        {
            var comparison = new[] { 3 };
            var source = new[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(source.ContainsAny(comparison));
        }

        [Test]
        public void Will_return_false_because_the_comparison_values_are_not_in_the_source()
        {
            var comparison = new[] { 7 };
            var source = new[] { 1, 2, 3, 4, 5 };

            Assert.IsFalse(source.ContainsAny(comparison));
        }
    }
}
