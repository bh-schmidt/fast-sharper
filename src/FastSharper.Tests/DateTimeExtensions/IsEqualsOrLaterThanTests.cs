using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsEqualsOrLaterThanTests
    {
        [Test]
        public void Will_return_true_because_the_source_is_later_than_the_comparation()
        {
            var source = DateTime.Now.AddDays(1);
            var comparation = DateTime.Now;

            Assert.IsTrue(source.IsEqualsOrLaterThan(comparation));
        }

        [Test]
        public void Will_return_false_because_the_source_is_earlier_than_the_comparation()
        {
            var source = DateTime.Now;
            var comparation = DateTime.Now.AddDays(1);

            Assert.IsFalse(source.IsEqualsOrLaterThan(comparation));
        }

        [Test]
        public void Will_return_true_because_the_source_is_the_same_as_the_comparation()
        {
            var source = DateTime.Now;

            Assert.IsTrue(source.IsEqualsOrLaterThan(source));
        }
    }
}
