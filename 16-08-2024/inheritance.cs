using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Dog Single-----");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.WriteLine("-----Puppy Multilevel-----");
            Puppy puppy = new Puppy();  
            puppy.Weep();
            puppy.Eat();
            puppy.Bark();
            Console.WriteLine("-----Cat Hierarchial -----");
            Cat cat = new Cat();
            cat.Meow();
            cat.Eat();
        }
    }
}
