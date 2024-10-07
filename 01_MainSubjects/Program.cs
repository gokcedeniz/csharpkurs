using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");

            //Console.Write("Selam");

            //Console.WriteLine("*** Yemek Kategorileri ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*** Yemek Kategorileri ***");

            #endregion

            #region String Değişkenler

            //string

            //tanımlama: Değişken_türü değişken_adı;

            //string name;
            //name = "Gokce";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Deniz";
            //customerSurname = "Yılmaz";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Sultanbeyli";
            //city = "İstanbul";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Fatma";
            //customerSurname = "Berrak";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Mudanya";
            //city = "Bursa";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Fiyat Menüsü ***");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---Kola: " + cokePrice + " TL");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyatı ***");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutar: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Tutar: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutar: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutar: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutar: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutar: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}