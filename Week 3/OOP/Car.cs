using System;

namespace OOP
{
    public class Car
    {
        // Car attributes
        public string Make;
        public string Model;
        public string Color;
        public int TopSpeed;
        public int CurrentSpeed;


        public Car(string carMake, string carModel, string carColor, int carTopSpeed)
        {
            Make = carMake;
            Model = carModel;
            Color = carColor;
            TopSpeed = carTopSpeed;
            CurrentSpeed = 0;
        }

        // Sounds the car's horn
        public void SoundHorn()
        {
            System.Console.WriteLine("Beep! Beep!");
        }

        // Accelerates the car by 5
        public void Accelerate()
        {
            if (CurrentSpeed >= TopSpeed) {
                CurrentSpeed = TopSpeed;
            } else {
                CurrentSpeed += 5;
            }
        }

        // Slows car down by 4
        public void SlowDown()
        {
            // Speed can't be a negative value
            if (CurrentSpeed <= 4)
            {
                CurrentSpeed = 0;
            }
            else
            {
                CurrentSpeed -= 4;
            }
        }

        // Stop cars
        public void EmergencyStop()
        {
            CurrentSpeed = 0;
        }

        // Gives car a different color
        public void Repaint(string newColor)
        {
            Color = newColor;
        }

        // Displays all attributes
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Top Speed: {TopSpeed}");
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
        }
    }

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
            for (int i = 0; i < 10; i++)
            {
                carOne.Accelerate();
            }
            carOne.SoundHorn();
            carOne.EmergencyStop();
            // carOne.DisplayInfo();

            // ----- Car 2 -----
            Console.WriteLine("\nCar 2");
            carTwo.Accelerate();

            // Slowdown twice
            for (int i = 0; i < 2; i++)
            {
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




