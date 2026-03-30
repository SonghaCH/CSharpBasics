using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0f;
            float b = 0f;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("간단한 정수 계산기 만들기!");
            Console.WriteLine("연산 형식은 a ㅁ b 형태로 ");
            Console.WriteLine("a의 숫자와 b 숫자를 대입한 후");
            Console.WriteLine("사칙연산 기호를 선택하여 계산합니다");
            Console.WriteLine("*주의* 예외처리 장치 구현이 되지않아 올바른 값을 입력하시길 바랍니다!");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("a 에 들어갈 수를 입력 하시오.");
            a = float.Parse(Console.ReadLine());



            Console.WriteLine("b 에 들어갈 수를 입력 하시오.");
            b= float.Parse(Console.ReadLine());


            Console.WriteLine("사칙 연산할 연산 기호를 입력하시오, ");
            Console.WriteLine("+ - * / ");



            while (true)
            {

                string op = Console.ReadLine();
                

                if (op == "+")
                {
                    Console.WriteLine(a + b);
                }
                else if (op == "-")
                {
                    Console.WriteLine(a - b);
                }
                else if (op == "*")
                {
                    Console.WriteLine(a * b);
                }
                else if (op == "/")
                {
                    Console.WriteLine(a / b);
                }
                else if (op == "0")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("다른 기호를 입력해주세요");
                }

                Console.WriteLine("\n\n다른 사칙 연산을 하려면 다른 기호를 입력하세요.\n\n");
                Console.WriteLine("\n\n{계산을 그만하시려면 0번을 눌러주세요}\n\n");
            }


        }
    }
}
