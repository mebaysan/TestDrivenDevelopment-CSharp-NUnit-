using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BussinessLayer
{
    public class KullaniciManager
    {
        public bool KullaniciEkle(string ad, string tel, string mail)
        {
            // iş kurallarımızı yazdık
            if (ad.Length < 4) return false; // ad 4 karakterden küçükse kaydetme
            if (!Regex.IsMatch(tel, "[0-9]")) return false;   // telefon istediğimiz pattern'e uygun olmalı
            if (mail.Contains("@")) return false; // mail adresinde @ işareti geçmeli
            return true;
        }
    }
}
