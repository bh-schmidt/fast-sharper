using NUnit.Framework;
using System.Collections.Generic;

namespace FastSharper.Tests.IEnumerableExtensions
{
    public class ToCsvTests : BaseTests
    {
        private const char comma = '"';

        [Test]
        public void Will_return_the_csv_with_header()
        {
            var header = new[] { "number", "half the number" };
            var data = new[] { 1, 2, 3 };

            var csv = data.ToCsv(
                (value, map) =>
                {
                    map(value);
                    map((double)value / 2);
                },
                header);

            var csvText = csv.ToString();

            var expected =
$@"{comma}number{comma},{comma}half the number{comma}
{comma}1{comma},{comma}0.5{comma}
{comma}2{comma},{comma}1{comma}
{comma}3{comma},{comma}1.5{comma}
";

            Assert.AreEqual(expected, csvText);
        }

        [Test]
        public void Will_return_the_csv_without_header()
        {
            var data = new[] { 1, 2, 3 };

            var csv = data.ToCsv(
                (value, map) =>
                {
                    map(value);
                    map((double)value / 2);
                });

            var csvText = csv.ToString();

            var expected =
$@"{comma}1{comma},{comma}0.5{comma}
{comma}2{comma},{comma}1{comma}
{comma}3{comma},{comma}1.5{comma}
";

            Assert.AreEqual(expected, csvText);
        }

        [Test]
        public void Will_throw_src_is_null()
        {
            IEnumerable<int>? data = null;

            Assert.Catch(() => data!.ToCsv((e, x) => { }));
        }

        [Test]
        public void Will_throw_mapFields_is_null()
        {
            var data = new[] { 1, 2, 3 };

            Assert.Catch(() => data!.ToCsv(null!));
        }
    }
}
