using System;

namespace LuckyDrawGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random(); //C# 스타일 랜덤함수 작성
            int JackPot = rand.Next(1, 21); // 1부터 20까지의 랜덤수 생성

            int CountCoin = 10;
            int ChoiceNumber;
            int EnterButton;

            Console.WriteLine("*반갑습니다. 행운의 뽑기 시간입니다.*");
            Console.WriteLine("\n코인은 총 10개이며 10번안에 맞추지 못할시 게임오버 됩니다.");
            Console.WriteLine("\n1부터 20까지 숫자이며 정답은 단 1개입니다.");

            for (; ; )  // 0또는 1번을 눌렀을때, 다시 시도하는 반복문
            {
                Console.WriteLine("<진행하려면 (1)번을, 종료 하시려면 (0)번을 눌러주세요.>\n");

                // 입력받은 문자열을 정수로 변환
                if (int.TryParse(Console.ReadLine(), out EnterButton))
                {
                    if (EnterButton == 1)
                    {
                        Console.WriteLine("게임을 시작하겠습니다!");
                        break;
                    }
                    else if (EnterButton == 0)
                    {
                        Console.WriteLine("종료 버튼을 누르셨습니다! \n게임이 종료 됩니다.");
                        return; // 프로그램 종료
                    }
                    else
                    {
                        Console.WriteLine("\n잘못 입력하셨습니다. 1번 혹은 0번을 입력해주세요");
                    }
                }
                else
                {
                    Console.WriteLine("\n숫자만 입력해주세요.");
                }
            }

            Console.WriteLine("1부터 20까지 입력하여 당첨을 찾아십시오.");

            for (int i = 1; i <= CountCoin; i++)
            {
                for (; ; ) // 1부터 20사이만 입력하도록 반복
                {
                    if (int.TryParse(Console.ReadLine(), out ChoiceNumber))
                    {
                        if (ChoiceNumber >= 1 && ChoiceNumber <= 20)  // 정상 입력시 진행
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n1부터 20사이만 입력해주세요.(코인은 차감되지않습니다.)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n숫자만 입력해주세요.");
                    }
                }

                if (ChoiceNumber == JackPot)
                {
                    Console.WriteLine("\n7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7\n잭팟! 정답입니다! 상품은 주강사님의 *격려* 입니다\n축하드립니다!");
                    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    return; // 프로그램 종료
                }
                else
                {
                    Console.WriteLine("\n아쉽게도 정답이 아닙니다");
                    Console.WriteLine("남은 코인:  " + (CountCoin - i) + " 개 남았습니다. 상품이 매우 값진 보상이니 화이팅!");

                    if (i == CountCoin)
                    {
                        Console.WriteLine("\n\n\n\n\n모든 코인을 소진하셨습니다. \nG  a   m  e       O  v  e   r");
                        Console.WriteLine("\n\n\n\n<<아쉽게도 정답은 [" + JackPot + "] 이었습니다.>>");
                    }
                }
            }
        }
    }
}