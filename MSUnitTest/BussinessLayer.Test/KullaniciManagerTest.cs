using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace BussinessLayer.Test
{
    [TestClass]
    public class KullaniciManagerTest
    {
        public TestContext TestContext { get; set; } // TestContext'i dahil ediyoruz ki data'yı dönerken yakalayabilelim.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"C:\Users\Yusuf\source\repos\TestDrivenDevelopment-CSharp.NUnit\MSUnitTest\BussinessLayer.Test\Kullanicilar.xml", "Kullanici", DataAccessMethod.Sequential)]
        // ilk parametre provider name, ikinci parametre data source(data'nın yeri)(ayrıca burada aynı proje altındaki kullanicilar.xml'i vermek için explorer'dan data üstüne tıkla properties->copy to output'u copy to always yap), ücüncü parametre tablo adı (xml ile çalıştığımızdan satır adı), dördüncü parametre dataları random mu yoksa sequential(sıralı) mı işlesin
        [TestMethod]
        [Owner("Baysan")] // Owner attribute testi kimin yazdığını belirlememizi sağlar.
        [TestCategory("Deneme")] // TestCategory methodu testlerimizi gruplamamızı sağlar.
        [Priority(1)] // Priority attribute testlere öncelik sırası vermemizi sağlar.
        [TestProperty("Güncelleyen","Enes")] // TestProperty attribute sınıflamamızı sağlar. İlk parametre isim, ikinci parametre bunu kimin yazdığıdır.
        [Ignore] // Ignore attribute testleri atlamamızı(skip) sağlar.
        [Timeout(1000)] // Timeout attribute parametre olarak milisaniye alır. Test eğer 1000 milisaniye üstünde olursa timeout(fail) olur.
        [Description("bu bir data driven testtir!")] // Description attribute yorum eklememizi sağlar.
        public void KullaniciEkleTest()
        {

            var manager = new KullaniciManager();
            var ad = TestContext.DataRow["ad"].ToString(); // ad değişkenini gelen data satırındaki ad değerinden
            var telefon = TestContext.DataRow["telefon"].ToString(); // telefon değişkenini gelen data satırındaki telefon değerinden
            var mail = TestContext.DataRow["mail"].ToString();  // mail değişkenini gelen data satırındaki mail değerinden
            var sonuc = manager.KullaniciEkle(ad, telefon, mail);

            Assert.IsTrue(sonuc); // sonuc true olmalı dedik
        }
    }
}
