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


            public void InitAllSkill()
            {
                // 스킬 두개를 추가하는 역할이 Main에서 Player 스스로로 역할이전
                var firstSkill = new Skill();
                firstSkill.m_id = "dummySkill_01";

                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(new Skill());
                m_mySkillList.Add(firstSkill);
                m_mySkillList.Add(new Skill());
            }

            public void UseSkill(string skillDataId)
            {
                foreach (var skill in m_mySkillList)
                {
                    if (skill == null)
                    { // 비교연산 - 안정적인 코드
                        continue;
                    }

                    // m_id가 null이나 공백문자가 아니면서, && AND 스킬의 Id가 파라미터로 전달됬다
                    bool isStringVaild = (string.IsNullOrEmpty(skill.m_id) == false);
                    bool isSkillDataIdSame = (skill.m_id == skillDataId);
                    bool isSkillUsable = (isStringVaild && isSkillDataIdSame);

                    if (isSkillUsable == true)
                    {
                        skill.ExecuteSkill();
                        break;
                    }
                }
            }

        }


        public class Skill
        {
            public string m_id;

            public void ExecuteSkill()
            {
                Console.WriteLine($"{m_id} 스킬을 사용함");
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
