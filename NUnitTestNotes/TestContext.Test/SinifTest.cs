using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SinifTest
    {
        public TestContext TestContext { get; set; } // asp.net vs gibi yerlerde page'den gelen datay� page tipini urli vs bu nesne sayesinde ula��r�z. ya da data tiplerine vs. TestContext'ten ula��l�r.
                // TextContext nesnemize eri�iyoruz.
        
        [SetUp]
        public void BaslangicIslemi()
        {
            TestContext.WriteLine("Test output "); // output k�sm�na yaz� yazmam�z� sa�lar.
            
        }
        [Test]
        public void ToplaMethoduCalisacakmi()
        {
            Assert.Pass();
        }
    }
}