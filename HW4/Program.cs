using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck(5.3, 1);
            Ostrich ostrich = new Ostrich(15.4, 10);
            Dog doggo = new Dog(10.3, 15);
            Cat kitty = new Cat(3.1, 2);

            Console.WriteLine(duck);
            duck.CanEat();
            IFlying icanfly = new Duck();
            icanfly.CanFly();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(ostrich);
            ostrich.CanEat();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(doggo);
            doggo.CanEat();
            IBark icanbark = new Dog();
            icanbark.CanBark();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(kitty);
            kitty.CanEat();
            IMew icanmew = new Cat();
            icanmew.CanMew();
            Console.ReadKey();
        }
    }
}
