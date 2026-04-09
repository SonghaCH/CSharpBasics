using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    public class Player
    {
        public void UseSkill(Skill dataID)
        {
            Console.WriteLine($"{dataID}");
        }

    }

    public class Skill
    {
        public void UsedSkillByExecuteSkill(string dataID)
        {
            dataID = string.Empty;
        }
    }


    internal class Program
    {
        
        public static void Main(string[] args)
        {
           Player player1 = new Player();
           List<Skill> skillList = new List<Skill>();
           skillList.Add(new Skill());
           skillList.Add(new Skill());

        }
    }
}
