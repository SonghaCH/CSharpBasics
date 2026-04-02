using System;

namespace Toolclass
{

    public class Tool
    {
        protected string m_toolName = string.Empty;
        protected int m_toolWeight = 0;
        protected int m_toolDurability = 100;
        protected string m_some = string.Empty;


        public void callName(string name)
        {
            m_toolName = name;
            Console.WriteLine($"이 도구는 {m_toolName} 입니다.");
        }




        public void Repair()
        {
            Console.WriteLine($"{m_toolName}를 수리합니다 \n");

            if (m_toolDurability >= 100)
            {
                Console.WriteLine($"이미 내구도가 {m_toolDurability} 입니다. (100 이상일때는 수리 되지 않습니다.)\n");
            }

            else
            {
                m_toolDurability += 1;
                Console.WriteLine($"{m_toolName}의 내구도가 1만큼 상승했습니다. 현재 내구도 {m_toolDurability}입니다 \n");
            }

        }

        public void UseTool()
        {
            Console.WriteLine($"{m_toolName}를 사용합니다 \n");



            if (m_toolDurability <= 0)
            {
                Console.WriteLine($"{m_toolName}의 내구도가 없습니다. 수리하여 주세요.\n");

            }
            else
            {
                m_toolDurability -= 10;
                Console.WriteLine($"{m_toolName}의 내구도가 -10만큼 하락했습니다. 현재 내구도 {m_toolDurability} 입니다.\n");

            }


        }

        public virtual void GetSomething(string some)
        {
            m_some = some;
            Console.WriteLine($"{m_toolName}을 사용하였더니 {some}을 수확 하였습니다.");
        }


    }



    public class Weapon : Tool
    {

        public void callName()
        {

        }
        public override void GetSomething(string some)
        {
            Console.WriteLine($"{m_toolName}을 사용하였더니 {some}을 죽였습니다");
        }

    }






    class Program
    {
        static void Main(string[] args)
        {
            Tool myTool = new Tool();
            myTool.callName("분무기");
            myTool.UseTool();
            myTool.Repair();
            myTool.GetSomething("농작물");

            Weapon myWeapon = new Weapon();
            myWeapon.callName("장검");
            myWeapon.UseTool();
            myWeapon.GetSomething("몬스터");
            myWeapon.Repair();

        }
    }

}








    
