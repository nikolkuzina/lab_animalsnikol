using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAnimals
{
    abstract class Animal
    {
        public float weight;
        public string color;
     
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Animal(string color, float weight)
        {
            this.weight = weight;
            this.color = color;
        }
        
        public abstract string MakeSound();
    }

    abstract class AnimalWithTail : Animal
    {
        public float tailLength;
        
        public float TailLength
        {
            get { return tailLength ; }
            set { tailLength = value; }
        }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color,weight)
        {
            base.color = color;
            base.weight = weight;
            this.tailLength = tailLength;
        }
    }

    class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
            base.color = color;
            base.weight = weight;
            base.tailLength = tailLength;
        }
        
        private string Purr()
        {
            return "Purr";
        }
        private string Meow()
        {
            return "Meow";
        }
        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return $"This is a cat, Color = { Color }, Weight = { Weight }, TailLength = {TailLength }";
        }
    }

    class Dog : AnimalWithTail
    {
        public Dog (string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
            base.color = color;
            base.weight = weight;
            base.tailLength = tailLength;
        }
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return $"This is a dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть колір кота");
            string color = Convert.ToString ( Console.ReadLine() );

            Console.WriteLine("Введіть вагу кота");
            float weight = Convert.ToSingle ( Console.ReadLine() ) ;

            Console.WriteLine("Введіть довжину хвоста кота");
            float tailLength = Convert.ToSingle(Console.ReadLine() );

            Cat cat = new Cat(color, weight, tailLength);

            Console.WriteLine(cat.ToString());

            Console.WriteLine(cat.MakeSound());

            Console.WriteLine("Введіть колір собаки");
            color = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введіть вагу собаки");
            weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введіть довжину хвоста собаки");
            tailLength = Convert.ToSingle(Console.ReadLine());

            Dog dog = new Dog(color, weight, tailLength);

            Console.WriteLine(dog.ToString());

            Console.WriteLine(dog.MakeSound());
            Console.ReadKey();
        }
    }
}
