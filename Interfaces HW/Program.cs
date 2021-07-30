using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*interface - is a contract of functions/abilities, if a class wishes to ultilize an interface
              the class must use all functions/abilites of the interface.*/

            #endregion

            #region question 2

            /*marker interface - is an empty interface without any functions/abilites used to "mark" an object.*/

            #endregion

            #region question 3

            /*names of interfaces are written with a capital 'I' at the beginning.*/

            #endregion

            #region question 4

            /*the default access modifier for an interface is internal(Can be changed), and the default access modifier for
              interface members is public.*/

            #endregion

            #region question 5

            /*it is not possible to utilize functions inside an interface, only declare their signatures.*/

            #endregion

            #region question 6

            /*it's possible to create a property inside an interface, since properties already have predefined methods.*/

            #endregion

            #region question 7

            /*it is not possible to generate fields inside of an interface.*/

            #endregion

            #region question 8

            /*an interface can inherit from a different interface, that means the inherting interface
              will add to his contract the abilites/functions of the inherted interface.*/

            #endregion

            #region question 9

            /*i think interfaces work sort of like a constructor, with parameters.
              meaning - each class that wishes to utilize an interface has to initialize all the interfaces abilites/functions,
              in other words has to give all the parameters in order to use.*/

            #endregion

            #region question 10

            /*as - means casting an interface "as" a different interface.
              is - means casting and checking if interface casting worked, if not return null.*/

            #endregion

            #region question 11

            /*when as fails it returns null.*/

            #endregion

            #region question 12



            #endregion
        }

        public static void AnimalIsHungry(IAnimal myAnimal)
        {
            if (myAnimal is ISoundable)
            {
                (myAnimal as ISoundable).SoundBeforeEating();

                myAnimal.Eat();
            }
        }

        public static void AnimalIsTired(IAnimal myAnimal)
        {
            myAnimal.Sleep();
        }
    }
}
