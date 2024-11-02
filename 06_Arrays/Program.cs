using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Değişkentürü [] diziadı = new Değişkentürü [Elemansayısı]
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[3]);
            //colors[5] yazdıramam mesela çünkü 4 elemanlı, 3 indisli bir dizidir

            //her indise  atama yapmak zorunda değilim. atama yapmadığım indisler otomatik sıfır
            //int[] numbers = new int[10];
            //numbers[0] = 100;
            //numbers[1] = 284;
            //numbers[2] = 24;
            //numbers[3] = 76;
            //numbers[7] = 90;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "ankara", "istanbul", "bursa", "izmir", "kocaeli" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "mavi", "pembe", "sarı", "yeşil", "beyaz", "kırmızı", "mor" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3, 7, 42, 67, 364, 567, 985, 4643, 2421, 1873 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char tipinde dizi tanımlarken tek tırnak kullanılmalı 

            //int[] array = { 4, 52, 74, 35, 75, 85, 94, 35, 67, 12 };
            //int enBuyuk = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //    if (array[i] > enBuyuk)
            //    {
            //        enBuyuk = array[i];
            //    }
            //}

            //Console.WriteLine("dizideki en büyük sayı: " + enBuyuk);

            #endregion

            #region Dizi Metotları

            //dizi.length : dizinin uzunluğunu verir
            //string[] persons = { "ali", "veli", "cemre", "yeliz", "can", "ayşe", "emir" };
            //Console.WriteLine(persons.Length);

            //array.sort(dizi) : dizideki sayıları küçükten büyüğe sıralar
            //int[] numbers = { 3, 52, 75, 36, 58, 79, 47, 29, 11 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //reverse dizideki sayıları tersten sıralar.
            //int[] numbers = { 3, 52, 75, 36, 58, 79, 47, 29, 11 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.IndexOf(dizi,aranan) : dizinin içinde aranan değer varda indisini verir yoksa -1 yazar
            //string[] persons = { "ali", "veli", "cemre", "yeliz", "can", "ayşe", "emir" };
            //Console.WriteLine(Array.IndexOf(persons, "cemre"));

            //min ve max metotmalı en büyük ve en küçük değerleri verir dizi.max() ve dizi.min()
            //int[] numbers = { 3, 52, 75, 36, 58, 79, 47, 29, 11 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max());
            //Console.WriteLine("dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-----------------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers= new int[7];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen toplanacak sayıların {i+1}.sini giriniz");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int total = 0;
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine($"sayılarınızın toplamı= {total}");



            #endregion


            Console.Read();

        }
    }
}
