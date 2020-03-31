using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class CastToTests : BaseTests
    {
        [Test]
        public void Will_cast_to_int()
        {
            object source = int.MaxValue;

            var cast = source.CastTo<int>();

            Assert.AreEqual(int.MaxValue, cast);
        }

        [Test]
        public void Will_throw_exception_because_is_an_invalid_cast()
        {
            var source = short.MaxValue;

            Assert.Catch<InvalidCastException>(() => source.CastTo<byte>());
        }

        [Test]
        public void Will_throw_exception_because_source_is_null()
        {
            string source = null!;

            Assert.Catch<ArgumentNullException>(() => source.CastTo<byte>());
        }
    }
}
