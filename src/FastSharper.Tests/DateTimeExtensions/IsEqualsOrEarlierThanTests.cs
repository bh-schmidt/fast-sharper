using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsEqualsOrEarlierThanTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_the_source_is_earlier_than_comparation()
        {
            var source = DateTime.Now;
            var comparation = DateTime.Now.AddDays(1);

            Assert.IsTrue(source.IsEqualsOrEarlierThan(comparation));
        }

        [Test]
        public void Will_return_false_because_the_the_source_is_later_than_comparation()
        {
            var source = DateTime.Now.AddDays(1);
            var comparation = DateTime.Now;

            Assert.IsFalse(source.IsEqualsOrEarlierThan(comparation));
        }

        [Test]
        public void Will_return_true_because_the_the_source_is_same_as_comparation()
        {
            var date = DateTime.Now;

            Assert.IsTrue(date.IsEqualsOrEarlierThan(date));
        }
    }
}
