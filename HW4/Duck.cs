﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Duck:Animal,IFlying
    {
        public override void CanEat()
        {
            Console.WriteLine("I am a duck and I can eat");
        }
        void IFlying.CanFly()
        {
            Console.WriteLine("I am a duck and I can fly");
        }
        public Duck() { }
        public Duck(double weight, int age)
        {
            this.weight = weight;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Duck`s weight: {weight} \r\nDuck`s age: {age}";
        }
    }
}
