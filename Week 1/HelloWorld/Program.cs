using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int nextBirthday = age + 1;
            Console.WriteLine("Hello " + name + ", on your next birthday you will be " + nextBirthday);

        }
    }
}
