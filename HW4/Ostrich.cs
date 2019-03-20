using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Ostrich:Animal
    {
        public override void CanEat()
        {
            Console.WriteLine("I am a ostrich and I can eat");
        }
        public Ostrich() { }
        public Ostrich(double weight, int age) : base(weight, age) { }
        public override string ToString()
        {
            return $"Ostrich`s weight: {Weight} \r\nOstrich`s age: {Age}";
        }
    }
}
