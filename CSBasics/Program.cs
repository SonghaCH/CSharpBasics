using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{

    internal class Program
    {
        public class Player
        {
            private List<Skill> m_mySkillList = new List<Skill>();

            public void UseSkill(string skillDataId)
            {
                foreach (var skill in m_mySkillList)
                {
                    if (skill == null)
                    {
                        continue;
                    }
                    skill.ExecuteSkill();
                }

                Console.WriteLine(skillDataId);
            }

            public void InitAllSkill()
            {
                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(new Skill());
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
            player.InitAllSkill();
            player.UseSkill("dummySkill_01");
        }
    }
}
}