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

            }

            if (A.IsAlive() == true)
            {
                //B WON!
            }
            else
            {
                //A WON!
            }

        }
    }
}
