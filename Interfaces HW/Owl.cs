using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_HW
{
    class Owl : IAnimal, ISoundable
    {
        public void SoundBeforeEating()
        {
            Console.WriteLine("hoot hoot");
        }

        public void Eat()
        {
            Console.WriteLine("nom nom");
        }

        public void Move()
        {
            Console.WriteLine("woosh woosh");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz Zzz");
        }
    }
}
