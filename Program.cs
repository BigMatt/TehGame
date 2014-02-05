using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test_Game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Player;
            Character Monster;
            Random randr = new Random();
            Fight f;

            Player = new Character("Matt");
            Monster = new Character("Harpy");

            Console.WriteLine("A fight breaks out");


        
            while (Monster.hits > 0)
            {
                f = new Fight(Player, "onehanded", Monster);

                Console.WriteLine(f);
                if (f.roll > 100 - f.toHit)
                {
                    Console.WriteLine("The Attacker scores a " + f.damagetype + " hit for: " + f.damage + " damage.");
                }
                else
                    Console.WriteLine("A miss!");
                //Console.ReadLine();
            }
            


           // Console.WriteLine(Monster.stuff);
            Console.ReadLine();






        }









    }
}
