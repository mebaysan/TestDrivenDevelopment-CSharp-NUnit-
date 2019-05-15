using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlarim.Test
{
    /*
     * projeAdi.Test -> Test edilecek projeninAdı.Test (İsimlendirme standardı) 
     * classAdiTests -> Test edilecek classınadıTests (İsimlendirme standardı)
     * 3A Pattern -> Arrange Act Assert
     * Arrange -> bir test methodunda hazırlıkların yapıldığı kısım. İhtiyacımız olan değişkenlerin tanımlandığı kısım.
     * Act     -> eyleme geçtiğimiz kısımdır. Test etmek istediğimiz fonksiyonu(methodu) çağırdığımız ve sonucu aldığımız kısım.
     * Assert  -> testimizin başarılı olup olmadığını belirlediğimiz kısımdır.
     * Bu test projesinin referanslarına diğer Methodlarim adli projeyi dahil ettik.
     * [SetUp] -> bu attribute her test methodundan önce çalışır.
     * [TearDown]    -> bu attribute her test methodundan sonra çalışır.
     */
    [TestFixture] // bir class'ın test class olabilmesi için TestFixture attribute ile süslenmesi lazım. Diğer test frameworklerde bu attr isimleri dğeişebilir ama mantık aynı.
    public class FirstMethodTests
    {
        [SetUp] // bu örnek içerisinde yaptığımız SetUp ve TearDown attribute'lar pek anlam ifade etmez fakat fikir olması açısından. Mesela 10 test methodu varsa ve hepsinde aynı fonksiyonu mutlaka bir kere çalıştırıyorsak bunları SetUp içine alabiliriz.
        public void FirstLog()
        {
            Console.WriteLine("Test methodu çalışmaya başladı!");
        }
        [Test] // bir methodun test methodu olabilmesi için Test attribute'dan beslenmesi(süslenmesi) lazım.
        public void ToplaMethoduCalisiyormu_Test() // Test methodunun isimlendirilmesi önemlidir. Gereksinim neyse onun adı_Test -> isimlendirme standardı
        {
            // Arrange
            Random random = new Random(); // burada ihtiyacımız olan değişkenleri tanımladık.
            int x = random.Next(3, 50);
            int y = random.Next(5, 30);
            int beklenen = x + y; // beklediğimiz sonucu oluşturduk.

            // Act
            FirstMethod method = new FirstMethod(); // test edeceğimiz class'ı çağırdık
            int testSonuc = method.Topla(x, y); // burada gerçekleşecek olan sonucu istedik.

            // Assert
            Assert.AreEqual(beklenen, testSonuc, "{0} + {1} = {2} olmalıdır ", x, y, beklenen); // İstediğimiz sonuç şu -> beklenen değer ile (ilk parametre) gerçekleşen değer (ikinci parametre) birbirine eşit olması.
                                                                                                // verdiğimiz 3. parametre test fail olursa gösterilecek olan mesajdır.
                                                                                                // AreNotEqual -> bu method istediğimiz değer dışında bir şey olursa testi başarıyla sonuçlandırır. '!=' düşünebiliriz.
                                                                                                // AreSame  -> AreEqual değerlerinin aynı olmasına bakarken, are same referanslarının aynı olmasına bakar.
                                                                                                // AreNotSame -> bu ise AreNotEqual gibidir. Referansları eşit değilse test başarılı geçer.
                                                                                                // Inonclusive -> test başarılı fakat yeterli değil anlamındadır.
                                                                                                // IsInstanceOfType -> belirttiğimiz değerin o tipte olup olmadığına bakar --> Assert.IsInstanceOfType(beklenen,typeof(string))
                                                                                                // IsNotInstanceOfType -> belirttiğin değer beklediğin tipte değilse test başarılı olur.
                                                                                                // IsNull           -> dönen değer eğer 'null' boş ise test başarıyla sonuçlanır.
                                                                                                // IsNotNull        -> dönen değer null değilse test başarıyla sonuçlanır.
                                                                                                // Fail             -> belli bir şartta testin fail olmasını istersek bu methodu kullanıyoruz.
        }
        /*          Collection Asserts
         * CollectionAssert.AreEqual -> elemanlar ve sıraları aynı olmalıdır.
         * CollectionAssert.AreEquivalent -> elemanlar aynı fakat sırası farklı olabilir.
         * CollectionAssert.AreNotEqual  -> elemanlar ve sırası farklı olmalıdır.
         * CollectionAssert.AreNotEquivalent -> elemanlar farklı olmalıdır.
         * CollectionAssert.AllItemsAreNotNull -> gelen listede 'null' değer olmamalıdır. eğer 1 tane bile null değer varsa test başarısız olur.
         * CollectionAssert.AllItemsAreUnique  -> gelen her elemandan sadece 1 tane olmalıdır. eğer aynı elemandan 2 tane varsa test başarısız (fail) olur.
         * CollectionAssert.AllItemsAreUnique  -> CollectionAssert.AllItemsAreUnique(liste,typeof(string)) --> gelen elemanları hepsinin aynı tipte olmasını ister. yoksa test fail olursa. 
         * 
         */
        [Test]
        public void CarpMethoduCalisiyormu_Test()
        {
            Random random = new Random();
            int x = random.Next(3, 50);
            int y = random.Next(5, 30);
            int beklenen = x * y * 2; // beklenen değer

            FirstMethod firstMethod = new FirstMethod();
            int testSonuc = firstMethod.Carp(x, y);
            Assert.AreNotEqual(beklenen, testSonuc); // beklediğimiz değer ile sonuc değeri birbirine eşit olmadığı için test başarıyla sonuçlandı.
        }
        [TearDown]
        public void Logla()
        {
            Console.WriteLine("Test methodu çalışmayı bitirdi!");
        }
    }
}
