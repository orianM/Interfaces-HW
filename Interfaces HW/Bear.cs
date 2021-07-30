using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_HW
{
    class Bear : IAnimal, ISoundable
    {
        public void SoundBeforeEating()
        {
            Console.WriteLine("rawr roar");
        }

        public void Eat()
        {
            Console.WriteLine("nom  nom");
        }

        public void Move()
        {
            Console.WriteLine("thump thump");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz Zzz");
        }
    }
}
