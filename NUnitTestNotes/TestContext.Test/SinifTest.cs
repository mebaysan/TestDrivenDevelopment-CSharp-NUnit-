using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SinifTest
    {
        public TestContext TestContext { get; set; } // asp.net vs gibi yerlerde page'den gelen datayý page tipini urli vs bu nesne sayesinde ulaþýrýz. ya da data tiplerine vs. TestContext'ten ulaþýlýr.
                // TextContext nesnemize eriþiyoruz.
        
        [SetUp]
        public void BaslangicIslemi()
        {
            TestContext.WriteLine("Test output "); // output kýsmýna yazý yazmamýzý saðlar.
            
        }
        [Test]
        public void ToplaMethoduCalisacakmi()
        {
            Assert.Pass();
        }
    }
}