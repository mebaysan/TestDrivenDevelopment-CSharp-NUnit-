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
