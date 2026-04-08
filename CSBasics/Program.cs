using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{

    internal class Program
    {

        public static void MakeCoffe(int coffeeCount)
        {
            int cookedCoffeeCount = (coffeeCount * 2);
            int cafe = cookedCoffeeCount;
            Console.WriteLine(cafe);

            if (cookedCoffeeCount > 30)
            {
                Console.WriteLine($"요리된 커피 카운트가 {cookedCoffeeCount} 입니다.(리턴)");
                return;
            }


            if (cafe > 5)
            {
                Console.WriteLine($"카페 수는 {cafe} 입니다.");
                return;
            }
            else
            {
                Console.WriteLine("정말 많네요");
            }


            for (int i = 0; i < cafe; i++)
            {
                Console.WriteLine($"카페 {cafe}");
            }
        }
        public static void Main(string[] args)
        {
            MakeCoffe(50);

        }
    }
}
