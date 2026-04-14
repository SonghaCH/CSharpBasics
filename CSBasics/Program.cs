using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{

    public class Player
    {
       

        public string m_name { get; private set; }
        public int m_atk { get; private set; }
        public int m_hp { get; private set; }

        public Player(string name,int attack,int hp)
        {
            m_name = name;
            m_atk = attack;
            m_hp = hp;
        }

        public void ChangeName(string playerName)
        {
            m_name = playerName;
        }


        public void ChangeAtk(int playerAtk)
        {
            m_atk = playerAtk;
        }
        public void ChangeHp(int playerCurentHp)
        {
            m_hp = playerCurentHp;
        }

        public void Attack(Monster targetMonster)
        {
            Console.WriteLine($"{m_name} 이/가  {targetMonster.m_name} 을/를 공격했다.~");
            Console.WriteLine($"{m_atk}만큼의 피해를 주었다.");
            targetMonster.TakeDamage(m_atk);

        }
        public void TakeDamage(int monsterDamage)
        {
            m_hp = m_hp - monsterDamage;
            Console.WriteLine($"{m_name}의 체력이 {m_hp}가 되었다.~");

        }


    }

    public class Monster
    {
        public string m_name { get; private set; }
        public int m_atk { get; private set; }
        public int m_hp { get; private set; }

        public Monster(string name, int attack, int hp)
        {
            m_name = name;
            m_atk = attack;
            m_hp = hp;
        }

        public void ChangeName(string monsterName)
        {
            m_name = monsterName;
        }

        public void ChangeAtk(int monsterAtk)
        {
            m_atk = monsterAtk;
        }
        public void ChangeHp(int monseterCurentHp)
        {
            m_hp = monseterCurentHp;
        }
        

        public void Attack(Player targetPlayer)
        {
            Console.WriteLine($"{m_name} 이/가  {targetPlayer.m_name} 을/를 공격했다.~");
            Console.WriteLine($"{m_atk}만큼의 피해를 주었다.");
            targetPlayer.TakeDamage(m_atk);


        }
        public void TakeDamage(int playerDamage)
        {
            m_hp = m_hp - playerDamage; 
            Console.WriteLine($"{m_name}의 체력이 {m_hp}가 되었다.~");
        }

    }





    internal class Program
    {

        static void Main(string[] args)
        {
            Player player1 = new Player("잠만보",50,1000);
            Monster monster1 = new Monster("리자몽",100,500);
            player1.Attack(monster1);
            monster1.Attack(player1);
           

        }

    }
}
