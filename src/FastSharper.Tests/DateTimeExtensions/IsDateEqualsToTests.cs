using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsDateEqualsToTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_source_date_is_the_same_as_the_comparation_date()
        {
            var source = DateTime.Now;

            Assert.IsTrue(source.IsDateEqualsTo(source));
        }

        [Test]
        public void Will_return_false_because_the_source_date_is_different_from_the_comparation_date()
        {
            var source = DateTime.Now;
            var comparation = DateTime.Now.AddDays(1);

            Assert.IsFalse(source.IsDateEqualsTo(comparation));
        }
    }
}
