using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_HW
{
    class Fish : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("blub blub");
        }

        public void Move()
        {
            Console.WriteLine("blub blub");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz Zzz");
        }
    }
}
