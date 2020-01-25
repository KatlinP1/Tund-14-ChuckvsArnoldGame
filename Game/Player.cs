using System;

namespace Game
{
    class Player
    {
        public string Name { get; private set; }
        public int Hp { get; set; }


        public Player(string _name)
        {
            Name = _name;
            Random rnd = new Random();
            Hp = rnd.Next(100, 151);
            
        }

        public int MakeDamage()
        {
            var rnd = new Random();
            return rnd.Next(10, 51);
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Hp left {Hp}");
        }

        public bool IsDead()
        {
            return Hp < 1;
        }
        
    }

}