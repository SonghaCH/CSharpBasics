using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{
    public class Player
    {
        private string m_name;
        private int m_damage;
        public int m_hp { get; private set; }

        public Player()
        { 
            m_name = string.Empty;
            m_damage = 0;
            m_hp = 100;
        }
        
        public string GetName()
        {
            return m_name;
        }

        public void SetName(string name)
        {
           m_name = name;
        }

        public int Damage
        {
            get { return m_damage; }
            set {
                if(m_damage != value)
                    m_damage = value;
                }
        }

        public void ChangeHp(int hp)
        {
            m_hp = hp;
        }
        
    }

    internal class Program
    {

        static void Main(string[] args)
        {
           Player player1 = new Player();
            
            
            player1.SetName("철수");
            Console.WriteLine(player1.GetName());

            player1.Damage = 10;
            Console.WriteLine(player1.Damage);

            player1.ChangeHp(10000000);
            Console.WriteLine(player1.m_hp);
        }

    }
}
