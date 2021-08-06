using System;

namespace KieshaTPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Dooo do doo dooo");
            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("############");

            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringgg ring ringgg");
            s8.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("############");
        }
    }
}
