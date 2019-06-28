using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp() // her test methodu çalışmadan önce burası çalışacak böylelikle bir kere math class oluşturmuş olacağız ve gereksiz kod yazmaktan kurtulacağız
        {
            _math = new Math();
        }

        [Test]
        [TestCase(2, 1, 3)] // test methoduna parametre yolladık
        public void Add_WhenCalled_ReturnTheSumOfArguments(int a, int b, int expectedResult) // testi parametize ettik
        {

            var result = _math.Add(a, b);

            Assert.That(result, Is.EqualTo(expectedResult)); // gelen result 3 olmalı dedik
        }

        [Test]
        [Ignore("Çünkü 3 farklı durumu inceleyen 3 farklı test'e ihtiyacım yok.")]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Çünkü 3 farklı durumu inceleyen 3 farklı test'e ihtiyacım yok.")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Çünkü 3 farklı durumu inceleyen 3 farklı test'e ihtiyacım yok.")] // Ignore attribute -> Testi görmezden gelir pass geçer, denemez. İçeri parametre olarak sebebini ya da açıklayıcı bir mesaj yazabilirsiniz.
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1, 2, 2)] // sırasıyla 1 -> a, 2 -> b, 2 -> beklenenSonuc
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_NeZamanCagrilirsa_EnBuyukParametreyiDondur(int a, int b, int beklenenSonuc) // bu test methoduna 3 adet test case yolladık ve bu sayede tek tek 3 ayrı durumu da 3 ayrı method içerisinde incelemek zorunda kalmadık.
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(beklenenSonuc));
        }
        [Test]
        [TestCase(5)]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit(int limit)
        {
            var result = _math.GetOddNumbers(limit);

            Assert.That(result, Is.Not.Empty); // dönen IEnumerable'in boş olmamasını istiyor
            Assert.That(result.Count(), Is.EqualTo(3)); // toplamda 3 elemanlı olmalı
            Assert.That(result, Does.Contain(1)); // 1'i içermeli
            Assert.That(result, Does.Contain(3)); // 3'i içermeli
            Assert.That(result, Does.Contain(5)); // 5'i içermeli
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); // EquivalentTo -> result ile bir diziyi karşılaştırır. Aynı ise true değilse false gelir. Burda da yeni bir dizi oluşturup elemanları ekledik
            Assert.That(result, Is.Ordered); // eğer dönen değer iterate edilebilen bir değerse true döner
            Assert.That(result, Is.Unique); //  eğer dizide hiç yinelenen öge yoksa true döner
        }
    }
}
