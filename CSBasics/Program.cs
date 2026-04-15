using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{
    public class Player
    {

        public string Name { get; set; }

        public event Action OnEquip;

        public event Action OnSwing;


        public Player(string name)
        {
            this.Name = name;
        }


        public void EquipWeapon()
        {
            Console.Write($"{this.Name}이 ");
            OnEquip?.Invoke();
            OnEquip = null;
        }

        public void SwingWeapon()
        {
            Console.Write($"{this.Name}이 ");
            OnSwing?.Invoke();
            OnSwing = null;
        }


    }

    public class Weapon
    {
        public string Name { get; set; }

        public Weapon(string name)
        {
            this.Name = name;
        }

        public void EqequipedWeapon()
        {

            Console.WriteLine($"{this.Name}을 장착하였습니다.");
        }

        public void SwingedWeapon()
        {
            Console.WriteLine($"{this.Name}을 휘둘렀다.");

        }

    }



    internal class Program
    {

        static void Main(string[] args)
        {
            Player player111 = new Player("손오공");
            Weapon weapon222 = new Weapon("여의봉");
            player111.OnEquip += weapon222.EqequipedWeapon;
            player111.OnSwing += weapon222.SwingedWeapon;
            player111.EquipWeapon();
            player111.SwingWeapon();

            







        }

    }
}
