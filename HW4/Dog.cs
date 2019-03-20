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

        // TODO:
        // write 'public void IBark.CanBark()' make sense
        // only if Dog Inherit Multiple Interfaces With the Same Methods Named 'CanBark()'
        // good example: https://www.c-sharpcorner.com/UploadFile/rohatash/inherit-multiple-interfaces-with-the-same-method-name-in-C-Sharp/
        public void CanBark()
        {
            Console.WriteLine("I am a dog and I can bark");
        }
        public Dog() { }
        public Dog(double weight, int age) : base(weight, age) { }
        public override string ToString()
        {
            return $"Doggo`s weight: {Weight} \r\nDoggo`s age: {Age}";
        }
    }
}
