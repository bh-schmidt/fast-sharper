using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsEarlierThanTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_the_source_is_earlier_than_comparation()
        {
            var source = DateTime.Now;
            var comparation = DateTime.Now.AddDays(1);

            Assert.IsTrue(source.IsEarlierThan(comparation));
        }

        [Test]
        public void Will_return_false_because_the_the_source_is_later_than_comparation()
        {
            var source = DateTime.Now.AddDays(1);
            var comparation = DateTime.Now;

            Assert.IsFalse(source.IsEarlierThan(comparation));
        }

        [Test]
        public void Will_return_false_because_the_the_source_is_same_as_comparation()
        {
            var date = DateTime.Now;

            Assert.IsFalse(date.IsEarlierThan(date));
        }
    }
}
