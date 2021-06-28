using ExtensionMethods.Extensions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 8;
           int SayininKaresi= sayi.KaresiniAl();
            Console.WriteLine(SayininKaresi);

            Random random = new Random();
            string harf=random.RandomLetter();
            Console.WriteLine(harf);
        }
    }
}
