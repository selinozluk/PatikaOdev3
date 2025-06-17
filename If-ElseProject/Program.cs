using System;

namespace IfElseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan sayı girişi
            Console.WriteLine("Lütfen bir sayı giriniz:");

            // Kullanıcının girdiği değeri string olarak alır, integer'a çevirir
            int num = Convert.ToInt32(Console.ReadLine());

            // Sayının 10'a göre durumu
            if (num == 10)
            {
                Console.WriteLine("Girilen sayı değeri 10'a eşittir.");
            }
            else if (num < 10)
            {
           // Sayının 10'dan büyük olup olmadığı sorgusu
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");
            }

            // Sayı çift mi değil mi sorgusu
            if (num % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }
        }
    }
}
