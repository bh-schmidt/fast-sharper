using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsInRangeTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_source_is_between_the_start_and_the_end()
        {
            var source = DateTime.Now;
            var start = DateTime.Now.AddDays(-1);
            var end = DateTime.Now.AddDays(1);

            Assert.IsTrue(source.IsInRange(start, end));
        }

        [Test]
        public void Will_return_true_because_the_source_is_the_same_as_the_start()
        {
            var source = DateTime.Now;
            var end = DateTime.Now.AddDays(1);

            Assert.IsTrue(source.IsInRange(source, end));
        }

        [Test]
        public void Will_return_true_because_the_source_is_the_same_as_the_end()
        {
            var source = DateTime.Now;
            var start = DateTime.Now.AddDays(-1);

            Assert.IsTrue(source.IsInRange(start, source));
        }

        [Test]
        public void Will_return_false_because_source_is_earlier_than_start()
        {
            var source = DateTime.Now.AddDays(-1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddDays(1);

            Assert.IsFalse(source.IsInRange(start, end));
        }

        [Test]
        public void Will_return_false_because_the_source_is_later_than_end()
        {
            var source = DateTime.Now.AddDays(1);
            var start = DateTime.Now.AddDays(-1);
            var end = DateTime.Now;

            Assert.IsFalse(source.IsInRange(start, end));
        }
    }
}
