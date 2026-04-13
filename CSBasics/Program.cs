using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{
    public interface IStudyClass
    {
        void TakeClass();
        void DoHomework();
    }
    
    public interface IHaveLunch
    {
        void HaveLunch();
    }

    public interface ITakeRest
    {
        void TakeRest();
    }





    public class Songha : IStudyClass , IHaveLunch, ITakeRest
    {
        public void Work()
        {
            Console.WriteLine("나는 편의점 알바를 한다.");
        }

        public void TakeClass()
        {
            Console.WriteLine("수업을 들으며, 앞으로를 꿈꿉니다.");
        }

        public void DoHomework()
        {
            Console.WriteLine("Ai의 코드를 보지 않으려 노력하며 과제를 합니다.");
        }

        public void Game()
        {
            Console.WriteLine($"나는 게임을 하기로 했습니다. 어떤 게임을 할건지 입력하시오.");
            Console.WriteLine($"<진행하시려면 게임 입력후 6기 멤버들의 하루를 탐색하시오.>");

            string gameName = Console.ReadLine();

            Console.WriteLine($"나는 {gameName} 게임을 하였다.\n\n");


        }

        public void HaveLunch()
        {
            Console.WriteLine("난 오늘 점심으로 콩나물 국을 먹었다. ");
        }

        public void TakeRest()
        {
            Console.WriteLine("쉬는 시간마다 누워서 안정을 취합니다.");
        }
    }
    

    public class Gm06Members : IHaveLunch,ITakeRest,IStudyClass
    {
        public void GodLife()
        {
            Console.WriteLine("6기 멤버들은 수업 이후에도 갓생을 산다 ");
        }

        public void TakeClass()
        {
            Console.WriteLine("6기 멤버들은 강사님에게 경청하며 스킬들을 체화한다 .");
        }

        public void DoHomework()
        {
            Console.WriteLine("멤버들은 엄청난 기량으로 과제를 해치운다.");
        }
        public void HaveLunch()
        {
            Console.WriteLine("6기 멤버들은 호화로운 점심을 먹는다. ");
        }

        public void TakeRest()
        {
            Console.WriteLine("쉬는 시간에도 열심히 공부한다.");
        }


    }




    internal class Program
    {

        static void Main(string[] args)
        {
           Songha songha = new Songha();
            songha.TakeClass();
            songha.TakeRest();
            songha.HaveLunch();
            songha.DoHomework();
            songha.Work();
            songha.Game();

            Gm06Members friend1 = new Gm06Members();
            friend1.TakeClass();
            friend1.TakeRest();
            friend1.HaveLunch();
            friend1.DoHomework();
            friend1.DoHomework();
            friend1.GodLife();
        }

    }
}
