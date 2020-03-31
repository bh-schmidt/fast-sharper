using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ContainsAnyNumberTests: BaseTests
    {
        [Test]
        public void Will_return_true_because_contains_number()
        {
            var source = "test123";

            Assert.IsTrue(source.ContainsAnyNumber());
        }

        [Test]
        public void Will_return_false_because_does_not_contains_number()
        {
            var source = "test";

            Assert.IsFalse(source.ContainsAnyNumber());
        }

        [Test]
        public void Will_throw_source_is_null()
        {
            string source = null!;

            Assert.Catch<ArgumentNullException>(() => source.ContainsAnyNumber());
        }
    }
}
