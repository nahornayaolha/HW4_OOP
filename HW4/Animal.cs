using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public abstract class Animal
    {
        protected Animal() { }

        // TODO:
        // you can use this constructor on inherited classes with ": base(weight, age) { }"
        protected Animal(double weight, int age)
        {
            this.Weight = weight;
            this.Age = age;
        }

        public abstract void CanEat();
        // TODO:
        // fields names
        public double Weight;
        public int Age;
        
    }
}
