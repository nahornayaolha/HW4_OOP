using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Dog:Animal,IBark
    {
        public override void CanEat()
        {
            Console.WriteLine("I am a dog and I can eat");
        }
        void IBark.CanBark()
        {
            Console.WriteLine("I am a dog and I can bark");
        }
        public Dog() { }
        public Dog(double weight, int age)
        {
            this.weight = weight;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Doggo`s weight: {weight} \r\nDoggo`s age: {age}";
        }
    }
}
