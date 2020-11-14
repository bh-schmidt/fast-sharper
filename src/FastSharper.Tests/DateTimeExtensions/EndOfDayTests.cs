using NUnit.Framework;
using System;

namespace FastSharper.Tests.DateTimeExtensions
{
    public class EndOfDayTests : BaseTests
    {
        [Test]
        public void Will_execute_the_method_without_errors()
        {
            DateTime.Now.EndOfDay();
        }
    }
}
