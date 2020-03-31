using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class ContainsOnlyNumbersTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_contains_only_numbers()
        {
            var source = "1234";

            Assert.IsTrue(source.ContainsOnlyNumbers());
        }

        [Test]
        public void Will_return_false_because_contains_a_non_number_character()
        {
            var source = "test1234";

            Assert.IsFalse(source.ContainsOnlyNumbers());
        }

        [Test]
        public void Will_throw_source_is_null()
        {
            string source = null!;

            Assert.Catch<ArgumentNullException>(() => source.ContainsOnlyNumbers());
        }
    }
}
