using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper.Tests
{
    public class IsSequenceEqualsTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_the_sequence_of_the_enumerables_are_equal()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var comparison = new[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(source.IsSequenceEquals(comparison));
        }

        [Test]
        public void Will_return_true_because_both_enumerables_are_empty()
        {
            var source = Enumerable.Empty<object>();
            var comparison = Enumerable.Empty<object>();

            Assert.IsTrue(source.IsSequenceEquals(comparison));
        }

        [Test]
        public void Will_return_false_because_the_enumerables_counts_are_different()
        {
            var source = new[] { 1, 2, 3, 4, 5, 6 };
            var comparison = new[] { 1, 2, 3, 4, 5 };

            Assert.IsFalse(source.IsSequenceEquals(comparison));
        }

        [Test]
        public void Will_return_false_because_the_enumerables_sequences_are_different()
        {
            var source = new[] { 1, 2, 3, 5, 4 };
            var comparison = new[] { 1, 2, 3, 4, 5 };

            Assert.IsFalse(source.IsSequenceEquals(comparison));
        }

        [Test]
        public void Will_return_false_because_the_enumerables_have_been_changed_during_the_execution()
        {
            Mock<IEnumerable<long>> sourceMock = new Mock<IEnumerable<long>>();
            Mock<IEnumerator<long>> enumeratorMock = new Mock<IEnumerator<long>>();

            var source = new List<long>() { 1, 2, 3 };
            var comparison = new List<long>() { 1, 2, 3 };

            sourceMock.SetupSequence(x => x.GetEnumerator())
                .Returns(source.GetEnumerator())
                .Throws(new InvalidOperationException());

            var result = sourceMock.Object.IsSequenceEquals(comparison);

            Assert.IsFalse(result);
        }
    }
}
