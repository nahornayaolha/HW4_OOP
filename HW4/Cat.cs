using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Cat:Animal,IMew
    {
        public override void CanEat()
        {
            Console.WriteLine("I am a cat and I can eat");
        }
        void IMew.CanMew()
        {
            Console.WriteLine("I am a cat and I can mew");
        }
        public Cat() { }
        public Cat(double weight, int age)
        {
            this.weight = weight;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Cat`s weight: {weight} \r\nCat`s age: {age}";
        }
    }
}
