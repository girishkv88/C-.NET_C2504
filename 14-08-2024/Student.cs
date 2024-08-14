using System;

namespace LearnCSharp
{
    internal partial class Program
    {
        class Student
        {
            public int Id;
            public string Name;
            public int Mark1;
            public int Mark2;
            public int Mark3;

            public void TotalMark()
            {
                Console.Write($"Total Mark of {Name} is ");
                Console.WriteLine(Mark1 + Mark2 + Mark3);

            }

            public void Average()
            {
                double TotalMark = (Mark1 + Mark2 + Mark3)/3;
                Console.WriteLine($"Average Mark of {Name} is {TotalMark} ");

            }
        static void Main(string[] args)
        {
            var p1 = new Person();//created object p1 for class person
            p1.FullName = "Person 1";
            p1.MonthlySalary = 10_000;//read as 10000 in c # used as , seperator
            p1.Bonus = 500;

            var p2 = new Person//simplified object initialization
            {
                FullName = "Person 2",
                MonthlySalary = 20_000,
                Bonus = 1000
            };

            var s1 = new Student
            {
                Id = 1,
                Name = "Rahul",
                Mark1 = 90,
                Mark2 = 94,
                Mark3 = 98
            };

            var s2 = new Student
            {
                Id = 1,
                Name = "Girish",
                Mark1 = 95,
                Mark2 = 98,
                Mark3 = 97
            };

            s1.TotalMark();
            s1.Average();
            s2.TotalMark();
            s2.Average();

            p1.TotalSalary();
            p2.TotalSalary();

            string data = "some text";
            Console.WriteLine(data.GetType());//gettype used to get the type of data
            Console.WriteLine(p1.GetType());

        }
        }
    }
}
