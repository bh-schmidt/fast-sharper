using NUnit.Framework;

namespace FastSharper.Tests
{
    public class IsNullOrWhiteSpace : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_source_is_null()
        {
            string source = null!;

            Assert.IsTrue(source.IsNullOrWhiteSpace());
        }

        [Test]
        public void Will_return_true_because_the_source_is_empty()
        {
            string source = string.Empty;

            Assert.IsTrue(source.IsNullOrWhiteSpace());
        }

        [Test]
        public void Will_return_true_because_the_source_is_white_space()
        {
            string source = " ";

            Assert.IsTrue(source.IsNullOrWhiteSpace());
        }

        [Test]
        public void Will_return_false_because_the_source_is_not_null_empty_or_white_space()
        {
            string source = "25";

            Assert.IsFalse(source.IsNullOrWhiteSpace());
        }
    }
}
