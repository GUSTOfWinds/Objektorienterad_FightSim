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
                Console.ReadLine();

                B.Hurt(A.Attack());
                A.Hurt(B.Attack());
                Console.WriteLine("The Fighters retreat momentarily, trying to stay upright...");
            }

            if (A.IsAlive() == true)
            {
                Console.WriteLine("Fighter B Fell! Fighter A has won!");
                Console.WriteLine();
            }
            if (B.IsAlive() == true)
            {
                Console.WriteLine("Fighter A Fell! Fighter B has won!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Both Fighters Have Fallen! It's A Draw!");
                Console.ReadLine();
            }
        }
    }
}
