using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car("BMW", "X6", "Black", 180);
            Car carTwo = new Car("Lamborghini", "Aventador SVJ", "Black", 217);
            Car carThree = new Car("Lamborghini", "Urus", "Black", 200);

            // ----- Car 1 -----
            Console.WriteLine("Car 1");

            // Accelerate 10 times
            for(int i = 0; i < 100; i++) {
                carOne.Accelerate();
            }
            carOne.SoundHorn();
            // carOne.EmergencyStop();
            carOne.DisplayInfo();

            // ----- Car 2 -----
            Console.WriteLine("\nCar 2");
            carTwo.Accelerate();

            // Slowdown twice
            for(int i = 0; i < 2; i++) {
                carTwo.SlowDown();
            }
            Console.WriteLine($"{carTwo.Make} {carTwo.Model} current speed: {carTwo.CurrentSpeed}");
            // carTwo.DisplayInfo();

            // ----- Car 3 -----
            Console.WriteLine("\nCar 3");
            carThree.Repaint("Gunmetal Gray");
            carThree.DisplayInfo();
            

        }

    }
}