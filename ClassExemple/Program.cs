using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat gardfiled = new Cat("Gardfield", "Puma", 176, 15, true, 4, 2);
            Dog diabolo = new Dog("Diabolo", "Labrador", 156, 14, false, true, 34);

            gardfiled.Describe();
            gardfiled.Cry();
            gardfiled.Walk();
            Console.WriteLine();
            diabolo.Describe();
            diabolo.Cry();
            diabolo.Walk();
 
            Console.ReadKey(true);
        }
    }

    class Animal
    {
        public string Name,
                      Breed;
        public int Size,
                   Weight;
        public bool Sexe;
        public Animal(string name, string breed, int size, int weight, bool sexe)
        {
            Name = name;
            Breed = breed;
            Size = size;
            Weight = weight;
            Sexe = sexe;
        }

        public virtual void Cry()
        {
            Console.WriteLine("Hello");
        }
        public virtual void Describe()
        {
            Console.WriteLine($"Name:{Name} - Breed:{Breed} - Size:{Size} - Weight:{Weight} - {(Sexe ? "male" : "female")}");
        }
        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }

    class Cat : Animal
    {
        public int Legs,
                   HairLength;            
        public Cat(string name, string breed, int size, int weight, bool sexe, int legs, int hairlength) : base(name, breed, size, weight, sexe)
        {
            Legs = legs;
            HairLength = hairlength;
        }
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine($"I'm a cat, my name is {Name} and i have {Legs} legs");
        }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"And my hair length is of {HairLength} cm");
        }
    }

    class Dog : Animal
    {
        bool Tail;
        int Power;
        public Dog(string name, string breed, int size, int weight, bool sexe, bool tail, int power) : base(name, breed, size, weight, sexe)
        {
            Tail = tail;
            Power = power;
        }
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine($"I'm dog, my name is {Name} and i have {(Tail ? "a" : "no")} tail");
        }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"And my power is of {Power}");
        }
    }
}
