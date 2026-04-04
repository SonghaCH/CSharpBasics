using System;

namespace FantasticCreature
{
    public enum DangerGrade : byte
    {
        None,
        Low,
        Moderate,
        High,
        Extreme
    }

    public class FantasticCreature
    {
        protected string m_name = string.Empty;
        protected int m_level = 0;
        protected DangerGrade m_grade = DangerGrade.None;

        public FantasticCreature()
        {
        }

        public void PrintProfile()
        {
            Console.WriteLine($"[{m_name}]의 정보를 로드했습니다.");
            Console.WriteLine($"이름: {m_name}");
            Console.WriteLine($"레벨: {m_level}");
            Console.WriteLine($"위험 등급: {m_grade}");
            Console.WriteLine("----------------------------------");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{m_name}이/가 공격태세로 전환하였습니다.");
        }

        public virtual void Cry()
        {
            Console.WriteLine($"{m_name}이/가 숨을 들이쉽니다.");
        }
    }

    public class Dragon : FantasticCreature
    {
        public Dragon()
        {
            m_name = "드래곤";
            m_level = 90;
            m_grade = DangerGrade.Extreme;
        }

        public override void Attack()
        {
            Console.WriteLine("드래곤은 꼬리와 발톱으로 공격합니다.");
            SpecialAttack();
        }

        public override void Cry()
        {
            Console.WriteLine("드래곤은 '쿠오오오오오' 라는 울음소리를 냅니다.");
        }

        public void SpecialAttack()
        {
            Console.WriteLine("드래곤은 '브레스'라는 특수 기술을 사용 가능합니다.");
        }
    }

    public class Kraken : FantasticCreature
    {
        public Kraken()
        {
            m_name = "크라켄";
            m_level = 70;
            m_grade = DangerGrade.Moderate;
        }

        public override void Attack()
        {
            Console.WriteLine("크라켄은 크고 묵직한 수많은 다리로 공격합니다.");
        }

        public override void Cry()
        {
            Console.WriteLine("크라켄은 '쿠헬헬헬헬'이라는 울음소리를 냅니다.");
        }
    }

    public class NineTaleFox : FantasticCreature
    {
        public NineTaleFox()
        {
            m_name = "구미호";
            m_level = 40;
            m_grade = DangerGrade.Moderate;
        }

        public override void Attack()
        {
            Console.WriteLine("구미호는 날렵한 발톱으로 공격합니다.");
            SpecialSkill();
        }

        public override void Cry()
        {
            Console.WriteLine("구미호는 '아오오오오'이라는 울음소리를 냅니다.");
        }

        public void SpecialSkill()
        {
            Console.WriteLine("구미호는 '인간 둔갑' 이라는 특수 기술을 사용합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("======= 환상 생물 대사전 =======");
                Console.WriteLine("1번: 드래곤 정보");
                Console.WriteLine("2번: 크라켄 정보");
                Console.WriteLine("3번: 구미호 정보");
                Console.WriteLine("4번: 사전 닫기");
                Console.WriteLine("==================================");
                Console.Write("어떤 생물의 데이터를 보시겠습니까? : ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "4")
                {
                    Console.WriteLine("사전을 닫습니다.");
                    break;
                }

                FantasticCreature selectedCreature = null;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("드래곤의 정보를 선택하셨습니다.\n");
                        selectedCreature = new Dragon();
                        break;
                    case "2":
                        Console.WriteLine("크라켄의 정보를 선택하셨습니다.\n");
                        selectedCreature = new Kraken();
                        break;
                    case "3":
                        Console.WriteLine("구미호의 정보를 선택하셨습니다.\n");
                        selectedCreature = new NineTaleFox();
                        break;
                    default:
                        Console.WriteLine("올바른 번호를 선택하여 주십시오.");
                        Console.ReadKey();
                        continue;
                }

                if (selectedCreature != null)
                {
                    Console.Clear();

                    selectedCreature.PrintProfile();
                    selectedCreature.Cry();
                    selectedCreature.Attack();
                }

                Console.WriteLine("\n아무 키나 누르면 목록으로 돌아갑니다...");
                Console.ReadKey();
            }
        }
    }
}