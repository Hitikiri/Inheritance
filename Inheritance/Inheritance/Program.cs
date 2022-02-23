using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat()
                {weight = 3, length = 5, name = "Pisi"};
            cat.runSpeed = 20;
            cat.sound = "Miyav";
            Console.WriteLine(cat.GetProperties());
            Bird bird = new Bird() {length = 3, weight = 1, flyDistance = 2, flySpeed = 10, name = "minik kuş"};
            Console.WriteLine(bird.GetProperties());
        }
    }
}