using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSBasics
{
    internal class Program
    {
        public class Player
        {
            public List<Skill> m_mySkillList = new List<Skill>();


            public void UseSkill(string skillDataId)
            {
                Console.WriteLine(skillDataId);
            }
        }




        public class Skill
        {

            public void ExecuteSkill()
            {
                Console.WriteLine("스킬을 사용함");
            }
        }







        static void Main(string[] args)
        {
            Player player = new Player();
            player.UseSkill("dummySkill_01");

            player.m_mySkillList.Add(new Skill());
            player.m_mySkillList.Add(new Skill());

            foreach (var skill in player.m_mySkillList)
            {
                if (skill == null)
                {
                    continue;
                }
                skill.ExecuteSkill();
            }

        }
    }
}
