using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //metodadı()
            //Geriye değer döndürmeyen metodlar
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ayşe Yılmaz");
            //    Console.WriteLine("Hale Şahin");
            //    Console.WriteLine("Yılmaz Öztürk");
            //}

            //fonksiyon-metotu çağırma
            //CustomerList();

            //void Sum()
            //{
            //    int x = 5;
            //    int y = 2;
            //    int z;
            //    z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriterMethod(string customerName)
            //{
            //    Console.WriteLine(customerName); 
            //}
            //WriterMethod("Deniz");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri Adı : " + name);
            //    Console.WriteLine("Müşteri Soyadı : "+ surname);
            //}

            //CustomerCard("Ayşe", "Yazan");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int x, int y, int z)
            //{
            //    int result = x + y + z;
            //    Console.WriteLine("sayıların toplamı : " + result);
            //}
            //Sum(5235, 64, 9);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Halil Yılmaz";
            //}
            //sadece değer döndürdüğü için çağrıldığında ekrana bir şey yazdırmaz
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Kaya";
            //    string surname = "Bulut";
            //    return name + " " + surname;    
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital)
            //{
            //    string cardInfo = $"Ülke adı : {countryName} ------- Başkent: {capital}";
            //    return cardInfo;
            //}
            //string a, b;
            //Console.Write("Ülke adı giriniz : ");
            //a= Console.ReadLine();
            //Console.Write("Başkentini giriniz : ");
            //b= Console.ReadLine();
            //Console.WriteLine(CountryCard(a, b));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}

            //Console.WriteLine(Sum(134, 53));
            //Console.WriteLine(Sum(1, 4));
            //Console.WriteLine(Sum(928, 590));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string name, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result > 50)
            //    {
            //        return name + " isimli öğrenci dersi geçti. Ortalaması : " + result;
            //    }
            //    else
            //    {
            //        return name + " isimli öğrenci dersi geçemedi. Ortalaması : " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Kaya", 53, 85, 67));

            #endregion

            Console.Read();
        }
    }
}
