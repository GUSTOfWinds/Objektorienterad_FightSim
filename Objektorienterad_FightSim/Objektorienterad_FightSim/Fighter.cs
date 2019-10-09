using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorienterad_FightSim
{
    class Fighter
    {
        int hp;
        string name;
        Random generator = new Random();

        public Fighter()
        {
            hp = 45;
            hp += generator.Next(1, 11);
            Console.WriteLine("Enter the name of the fighter");
            name = Console.ReadLine();
            Console.WriteLine("The Fighter " + name + " enters the fray with " + hp + " health!");
        }

        public int Attack()
        {
            int damagedealt = generator.Next(1, 11);

            return damagedealt;
        }
        public void Hurt(int amount)
        {
            hp -= amount;
        }
        public int getHP()
        {
            return hp;
        }
        public bool IsAlive()
        {
            if (hp >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}