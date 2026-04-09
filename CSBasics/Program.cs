using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{
    public class Player
    {
        public List<ExecuteSkill> skillList = new List<ExecuteSkill>();
        public void UseSkill(string dataId)
        {
            Console.WriteLine(dataId);
        }
    }

    public class ExecuteSkill
    {
        public string m_dataId = string.Empty;

        public void UsedSkill()
        {

        }
    }

    internal class Program
    {
        


       

        static void Main(string[] args)
        {
            Player player1 = new Player();
            ExecuteSkill skill1 = new ExecuteSkill();
            skill1.m_dataId = "파이어볼";
            ExecuteSkill skill2 = new ExecuteSkill();
            skill2.m_dataId = "매직애로우";
            player1.skillList.Add(skill1);
            
            player1.skillList.Add(skill2);

            foreach (ExecuteSkill skill in player1.skillList )
            {
                player1.UseSkill(skill.m_dataId);
            }
        }
        
    }
}
