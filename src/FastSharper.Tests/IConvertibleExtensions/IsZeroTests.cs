using NUnit.Framework;
using System;

namespace FastSharper.Tests
{
    public class IsZeroTests : BaseTests
    {
        [Test]
        public void Will_return_true_because_is_a_false_boolean()
        {
            bool value = false;
            Assert.IsTrue(value.IsZero());
        }

        [Test]
        public void Will_return_true_because_is_a_zero_char()
        {
            char value = '0';
            Assert.IsTrue(value.IsZero());
        }

        [Test]
        public void Will_return_true_because_is_a_string_with_only_zeros_and_dots()
        {
            string value = "000.00";
            Assert.IsTrue(value.IsZero());
        }

        [Test]
        public void Will_return_true_because_is_a_type_number_with_value_zero()
        {
            decimal value = 0;
            Assert.IsTrue(value.IsZero());
        }

        [Test]
        public void Will_return_false_because_the_type_is_DateTime()
        {
            DateTime value = DateTime.Now;
            Assert.IsFalse(value.IsZero());
        }

        [Test]
        public void Will_return_false_because_the_type_cannot_be_converted_to_number()
        {
            ICovertibleImplementation value = new ICovertibleImplementation();
            Assert.IsFalse(value.IsZero());
        }

        [Test]
        public void Will_return_false_because_is_a_true_boolean()
        {
            bool value = true;
            Assert.IsFalse(value.IsZero());
        }

        [Test]
        public void Will_return_false_because_is_a_one_char()
        {
            char value = '1';
            Assert.IsFalse(value.IsZero());
        }

        [Test]
        public void Will_return_false_because_the_string_is_not_zero()
        {
            string value = "0.1";
            Assert.IsFalse(value.IsZero());
        }
    }
}
