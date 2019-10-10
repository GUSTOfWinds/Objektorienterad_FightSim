using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorienterad_FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter A = new Fighter();
            Fighter B = new Fighter();
            Console.WriteLine("The Fight Begins!");
            Console.ReadLine();

            while (A.IsAlive() && B.IsAlive())
            {
                Console.WriteLine("The Fighters Clash!");
                B.Hurt(A.Attack());
                A.Hurt(B.Attack());
                Console.WriteLine("The Fighters retreat momentarily, trying to stay upright...");
                Console.ReadLine();
            }

            if (A.IsAlive() == false && B.IsAlive() == false)
            {
                Console.WriteLine("Both Fighters Fell! It's A Draw!");
                Console.WriteLine();
            }
            else if (A.IsAlive() == false)
            {
                Console.WriteLine("Fighter " + A.name + " Fell! Fighter " + B.name + " has won!");
                Console.WriteLine();
            }
            else if (B.IsAlive() == false)
            {
                Console.WriteLine("Fighter " + B.name + " Fell! Fighter " + A.name + " has won!");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
