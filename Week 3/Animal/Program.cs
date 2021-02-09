using System;

namespace Animal
{
    class Shark
    {
        // Attributes
        public string name = "Jerry";
        public string color = "Off White";
        public int age = 300;
        public int energyLevel = 100;
        public int hungerLevel = 20;

        // Constructor
        Shark(string sharkName, string sharkColor, int sharkAge, int sharkEnergyLevel, int sharkHungerLevel)
        {
            name = sharkName;
            color = sharkColor;
            age = sharkAge;
            energyLevel = sharkEnergyLevel;
            hungerLevel = sharkHungerLevel;
        }

        // Feed the shark and sets hunger level to 0
        public void Feed()
        {
            hungerLevel = 0;
        }

        // Shark noise method
        public void Snap()
        {
            Console.WriteLine("Snap! Snap! Snap!");
        }

        public void Play()
        {
            Console.WriteLine($"**Playing with {name}**");
            energyLevel -= 10;
            hungerLevel += 5;
        }

        // Displays object attributes
        public override string ToString()
        {
            return ($"Name: {name}\nColor: {color}\nAge: {age}\nEnergy Level: {energyLevel}\nHungerLevel: {hungerLevel}");
        }
        static void Main(string[] args)
        {
            Shark myShark = new Shark("Jerry", "off white", 300, 100, 20);
            myShark.Feed();
            myShark.Snap();
            myShark.Play();
            Console.WriteLine(myShark.ToString());
        }
    }
}
