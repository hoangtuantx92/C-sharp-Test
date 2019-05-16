using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for HtmlFormatterTests
    /// </summary>
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //specific
           // Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
