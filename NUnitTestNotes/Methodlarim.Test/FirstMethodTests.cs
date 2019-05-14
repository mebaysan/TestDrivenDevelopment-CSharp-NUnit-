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
     */
    [TestFixture] // bir class'ın test class olabilmesi için TestFixture attribute ile süslenmesi lazım. Diğer test frameworklerde bu attr isimleri dğeişebilir ama mantık aynı.
    public class FirstMethodTests
    {
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
            Assert.AreEqual(beklenen, testSonuc); // İstediğimiz sonuç şu -> beklenen değer ile (ilk parametre) gerçekleşen değer (ikinci parametre) birbirine eşit olması.

        }
    }
}
