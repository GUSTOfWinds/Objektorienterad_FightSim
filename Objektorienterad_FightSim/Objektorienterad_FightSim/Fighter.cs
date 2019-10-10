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
        public string name;
        Random generator = new Random();

        public Fighter()
        {
            hp = 45;
            hp += generator.Next(1, 11);
            Console.WriteLine("Enter the name of the next fighter");
            name = Console.ReadLine();
            Console.WriteLine("The Fighter " + name + " enters the fray with " + hp + " health!");
        }

        public int Attack()
        {
            int damagedealt = generator.Next(1, 11);
            Console.WriteLine(name + " attacks for " + damagedealt + " damage!");
            return damagedealt;
        }
        public void Hurt(int amount)
        {
            hp -= amount;
            Console.WriteLine(name + " has " + hp + " health remaining!");
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