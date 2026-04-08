using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSharpLiveOnAir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coffeeCount = 10;
            int cookedCoffeeCount = (coffeeCount * 2);

            // 값복사 - 스택으로 치면 변수만 3개
            // 매번 이렇게 받을 필요는 없다 -> 다만 변수의 흐름과 대입에 대한 이해를 위해서
            // 의도적으로 퀴즈 문제가 그렇게 구성이 되었습니다.
            int cafeCount = cookedCoffeeCount;
            Console.WriteLine(cafeCount);

            // 아래와 똑같음
            // bool isCoffeeOverCooked = cookedCoffeeCount > 30;
            // if (isCoffeeOverCooked) { }

            if (cookedCoffeeCount > 30)
            {
                return;
            }


            if (cafeCount > 50)
            {
                return;
            }
            else
            {
                Console.WriteLine("카페가 정말 많네요!");
            }


            for (int i = 0; i < cafeCount; i++)
            {
                Console.WriteLine($"카페 : {i}");
            }

        }
    }
}
