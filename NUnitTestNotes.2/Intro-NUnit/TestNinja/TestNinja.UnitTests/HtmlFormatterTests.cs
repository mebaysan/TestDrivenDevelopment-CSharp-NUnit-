using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        [TestCase("bu bir testCase metnidir!")]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringsWithStrongElement(string metin)
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold(metin);
            // Specific Assertion
            Assert.That(result, Is.EqualTo($"<strong>{metin}</strong>"));
            //More General
            Assert.That(result, Does.StartWith("<strong>")); // sonuç <strong> ile başlasın dedik
            Assert.That(result, Does.EndWith("</strong>")); // sonuç <strong> ile bitsin dedik
            Assert.That(result, Does.Contain($"{metin}")); //  sonuç parametre olarak verilen metin değerini içersin dedik


        }
    }
}
