using NUnit.Framework;

namespace FastSharper.Tests
{
    public class IsEqualsTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_enumerables_contains_the_same_values()
        {
            var source = new[] { 1, 2, 3 };
            var comparison = new[] { 3, 2, 1 };

            Assert.IsTrue(source.IsEqualsTo(comparison));
        }

        [Test]
        public void Will_return_false_because_the_enumerables_count_are_different()
        {
            var source = new[] { 1, 2, 3, 4 };
            var comparison = new[] { 3, 2, 1 };

            Assert.IsFalse(source.IsEqualsTo(comparison));
        }

        [Test]
        public void Will_return_false_because_the_enumerables_contains_different_values()
        {
            var source = new[] { 1, 2, 3, 4 };
            var comparison = new[] { 3, 2, 1, 0 };

            Assert.IsFalse(source.IsEqualsTo(comparison));
        }
    }
}
