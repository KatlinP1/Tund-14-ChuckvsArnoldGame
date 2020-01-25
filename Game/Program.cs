using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Arnold =new Player("Arnold Schwarz");
            Player Chukc=new Player("Chuck Norris");
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" Round: {i+1}");
                Arnold.TakeDamage(Chukc.MakeDamage());
                if (Arnold.IsDead())
                {
                    Console.WriteLine("Arnold is dead!");
                    break;
                }
                Chukc.TakeDamage(Arnold.MakeDamage());
                if (Chukc.IsDead())
                {
                    Console.WriteLine("Chuck is dead!");
                    break;
                }
            }

            if (Arnold.Hp > Chukc.Hp)
            {
                Console.WriteLine($"Arnold is the winner {Arnold.Hp} with left");
            } else if (Chukc.Hp> Arnold.Hp)
            {
                Console.WriteLine($"Chuck is the winner {Chukc.Hp} with left");
            }
            else 
            {
                Console.WriteLine("It is a tie");
            }

            Console.ReadLine();


        }
    }
}