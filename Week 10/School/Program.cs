using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
                new Student {First="Bob", Last="Jones", ID=111, Age=15, Scores= new List<int> {69, 92, 81, 60}},
                new Student {First="Claire", Last="Simpson", ID=112, Age=17, Scores= new List<int> {75, 84, 83, 39}},
                new Student {First="John", Last="Feetham", ID=113, Age=21, Scores= new List<int> {65, 94, 65, 91}},
                new Student {First="Jonathan", Last="Potts", ID=114, Age=10, Scores= new List<int> {97, 83, 85, 62}},
                new Student {First="Pepe", Last="Garcia", ID=115, Age=20, Scores= new List<int> {35, 72, 91, 70}},
                new Student {First="Samantha", Last="Fakhouri", ID=116, Age=17, Scores= new List<int> {99, 86, 90, 54}},
                new Student {First="Roger", Last="Song", ID=117, Age=19, Scores= new List<int> {60, 72, 64, 45}},
                new Student {First="Hugo", Last="Garcia", ID=118, Age=15, Scores= new List<int> {92, 90, 83, 78}},
                new Student {First="Richard", Last="Ammerman", ID=119, Age=14, Scores= new List<int> {68, 79, 81, 92}},
                new Student {First="Kevin", Last="Adamson", ID=120, Age=11, Scores= new List<int> {68, 71, 81, 79}},
                new Student {First="Jeet", Last="Singh", ID=121, Age=12, Scores= new List<int> {96, 85, 91, 60}}
            };


            List<Staff> teacherList = new List<Staff>
            {
                new Staff {First="Jeet", Last="Singh", ID=900},
                new Staff {First="Richard", Last="Potter", ID=901},
                new Staff {First="Terry", Last="Woodward", ID=902},
                new Staff {First="Bob", Last="Feetham", ID=903},
                new Staff {First="Jane", Last="Feetham", ID=904},
                new Staff {First="Oliver", Last="Jones", ID=905},
                new Staff {First="Rafael", Last="Sacramento", ID=906},
                new Staff {First="John", Last="Smith", ID=907},
                new Staff {First="Pepe", Last="Garcia", ID=908}
            };

            List<Course> courseList = new List<Course>
            {
                new Course{Code="100AB",Name="Intro To Computers",Semester="Fall",Duration=15},
                new Course{Code="101AB",Name="Programming I",Semester="Winter",Duration=15},
                new Course{Code="102AB",Name="Programming II",Semester="Fall",Duration=15},
                new Course{Code="103AB",Name="Database I",Semester="Summer",Duration=5},
                new Course{Code="104AB",Name="Database II",Semester="Summer",Duration=5},
                new Course{Code="303ER",Name="Applied Mathematics",Semester="Summer",Duration=5},
                new Course{Code="304ER",Name="Pure Mathematics",Semester="Fall",Duration=15},
                new Course{Code="588A",Name="English Language",Semester="Winter",Duration=10},
                new Course{Code="589A",Name="English Literature",Semester="Winter",Duration=10},
                new Course{Code="588B",Name="More English Language",Semester="Fall",Duration=10},
                new Course{Code="589B",Name="More English Literature",Semester="Fall",Duration=10},
                new Course{Code="123Z",Name="Basic Biology",Semester="Winter",Duration=15},
                new Course{Code="123Y",Name="Basic Chemistry",Semester="Fall",Duration=15},
                new Course{Code="123X",Name="Basic Physics",Semester="Summer",Duration=8}
            };

            // 1. Students who are under 18 years of age
            /*var studentCount = (from w in studentList
                               where w.Age < 18
                               orderby w.Age ascending
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.First + " " + item.Age);
            }*/

            // 2. Students who are teenagers
            /*var studentCount = (from w in studentList
                                where w.Age > 13 && w.Age < 19
                                orderby w.Last
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.Last + " " + item.Age);
            }*/

            // 3. Students who scored 80 or more in their last test (order by score descending)
            /*var studentCount = (from w in studentList
                                where w.Scores[3] > 80
                                orderby w.Scores[3] descending
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.First + " " + item.Scores[3]);
            }*/

            // 4. Students who scored over 320 marks in total(across all their tests)
            /*var studentCount = (from w in studentList
                                where w.Scores.Sum() > 320
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.First + " " + item.Scores.Sum());
            }*/

            // 5. Students who scored at least 60 in all of their tests
            /*var studentCount = (from w in studentList
                                where w.Scores.Sum() >= 60
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.First + " " + item.Scores.Sum());
            }*/

            // 6. Students grouped by first letter of their last name
            /*var studentCount = (from w in studentList
                                group w by w.Last[0] into groups
                                select groups);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }*/

            // 7. Students who are also teachers
            /*var studentCount = (from w in studentList
                                join e in teacherList on w.First + w.Last equals e.First + e.Last
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.First + " " + item.Last);
            }*/

            // 8. Courses of a duration of 15 weeks
            /*var studentCount = (from w in courseList
                                where w.Duration == 15
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.Name + " " + item.Duration);
            }*/

            // 9. Courses held in the Winter semester(order by duration)
            /*var studentCount = (from w in courseList
                                where w.Semester == "Winter"
                                orderby w.Duration
                                select w);

            foreach (var item in studentCount)
            {
                Console.WriteLine(item.Name + " - " + item.Duration + " - " + item.Semester);
            }*/

            // 10. courses grouped by semester
            /*var studentCount = (from w in courseList
                                group w by w.Semester into groups
                                select groups);

            foreach(var item in studentCount)
            {
                Console.WriteLine(item.Key + ". Courses: " + item.Key.Count());
            }*/
        }
    }
}


