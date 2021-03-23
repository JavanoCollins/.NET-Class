
using System;
using System.Linq;

namespace LabExercise9b
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            
            // AGGREGATION

            // Aggegrate (simple)
            var aggregate = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine(aggregate);

            // Average
            var average = numbers.Average();
            Console.WriteLine(average);
            
            // Count
            var count = numbers.Count();
            Console.WriteLine(count);

            // GROUP BY

            // GroupBy
            var groupby = from n in numbers
                         group n by (n % 2 == 0) into groups
                         select groups;

            foreach(IGrouping<bool, int> group in groupby)
            {
                if(group.Key == true)
                {
                    Console.WriteLine("\nDivisible by 2:");
                } else
                {
                    Console.WriteLine("\nNot Divisible by 2:");
                }

                foreach(int number in group)
                {
                    Console.WriteLine(number);
                }
            }

            // JOIN
            string[] technologies = { "JavaScript","Linux", "Python", "Docker", "React", };
            string[] frameworks = { "React", "Django", "Linux", "Kubernetes" };
            var join = (from w in technologies
                        join e in frameworks on w equals e
                        select w);
            foreach (var technology in join)
                Console.WriteLine(technology);

            // ORDERING
            // OrderBy
            int[] fiveNumbers = { 100, 2000, 30000, 400000, 5000000 };

            var orderby = fiveNumbers.OrderByDescending(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in orderby)
                Console.WriteLine(number);

            // RESTRICTION
            string[] programmingFrameworks = { "React", "Vue", "Express", "Spring", "Django" };

            var restriction = programmingFrameworks.Where(n => n.Contains("e"));

            Console.WriteLine("Numbers being >= 15 and <= 25:");
            foreach (var language in restriction)
                Console.WriteLine(language);
        }
    }
}
