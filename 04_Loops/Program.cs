using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            //int x;
            //Console.WriteLine("hangi sayının bölenlerini bulmak istiyorsunuz? ");
            //x=int.Parse(Console.ReadLine());

            //for(int i = 1;i<=x; i++)
            //{
            //    if (x%i==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region For Döngüsü ile Karar Yapilari

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------------");
            //Console.WriteLine(totalValue);


            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //int i = 1, sum = 0;
            //while (i <= 10) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int x;
            //Console.WriteLine("hangi sayının bölenlerini bulmak istiyorsunuz? ");
            //x=int.Parse(Console.ReadLine());
            //int i = 1;
            //while(x >= i) 
            //{
            //if (x % i == 0)
            //    {
            //        Console.WriteLine(i); 
            //    }
            //    i++;
            //}


            #endregion

            #region Örnek Soru

            //klavyeden girilen üç basamaklı sayının basamakları toplamı 
            //int number, sum = 0, i, x;

            //Console.Write("Lütfen 3 basamaklı sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //for (i = 0; i < 3; i++)
            //{
            //    x = number % 10;
            //    number = number - x;
            //    number = number / 10;
            //    sum += x;
            //}

            //Console.WriteLine("Toplam: " + sum);

            #endregion
            Console.Read();
        }
    }
}