using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(110, 15);
            Ork ork = new Ork(95, 10);
            knight.TakeDamage(50);
            ork.TakeDamage(60);
        }
    }
    class Warrior
    {
        protected int Health;
        protected int Damage;
        protected int Armor;
        public Warrior(int health, int damage, int armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }
        public void TakeDamage(int Damage)
        {
            Health -= Damage - Armor;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }
    class Knight : Warrior
    {
        public Knight(int health, int damage) : base(health, damage, 10) { }
        public void Pray()
        {
            Armor += 2;
            Health += 5;
        }
    }
    class Ork : Warrior
    {
        public Ork(int health, int damage) : base(health, damage, 15) { }
        public void Pray()
        {
            Armor -= 4;
            Health += 5;
            Damage += 3;
        }
    }
}
