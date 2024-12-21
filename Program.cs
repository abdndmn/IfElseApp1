// See https://aka.ms/new-console-template for more information
using System;

namespace IfElse1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayi giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                if (number == 10)
                {
                    Console.WriteLine("Girilen sayi 10'a eşittir.");
                    Console.WriteLine("Girilen sayi çifttir.");
                }
                else if (number > 10)
                {
                    Console.WriteLine("Girilen sayi 10'dan büyüktür.");
                    Console.WriteLine("Girilen sayi çifttir.");
                }
                else
                {
                    Console.WriteLine("Girilen sayi 10'dan küçüktür");
                    Console.WriteLine("Girilen sayi çifttir.");
                }
            }
            else
            {
                if (number > 10)
                {
                    Console.WriteLine("Girilen sayi 10'dan büyüktür.");
                    Console.WriteLine("Girilen sayi tektir.");
                }

                else
                {
                    Console.WriteLine("Girilen sayi 10'dan küçüktür");
                    Console.WriteLine("Girilen sayi tektir.");
                }
            }


        }
    }
}
