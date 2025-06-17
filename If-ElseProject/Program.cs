using System;

namespace IfElseProject
{
    class Program
    {
        static void Main(string[] args)
        {
               // Kullanıcıdan sayı girişi
                Console.WriteLine("Lütfen bir sayı giriniz:");

              // Kullanıcının girdiği değeri string olarak alarak integer değerine dönüştürür ve num değişkenine atar
                int num = Convert.ToInt32(Console.ReadLine());

                // Sayının 10'dan büyük olup olmadığı sorgusu
                 if (num > 10)
                {
                    // Sayı > 10 ise burası çalışır
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");

                    // Sayı çift mi değil mi sorgusu
                 if (num % 2 == 0)
                    {
                    // Hem büyük hem de çiftse bu blok çalışır
                        Console.WriteLine("Girilen sayı çifttir.");
                    }
                    else
                    {
                   // Sayı hem büyük hem tekse çalışır
                        Console.WriteLine("Girilen sayı tektir");
                    }
                }
                else
                {
                  // Sayı 10'dan küçükse veya eşitse burası çalışır
                    Console.WriteLine("Girilen sayı 10'dan küçük veya eşittir.");
                    }
            }
        }
    } 