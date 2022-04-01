using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections.Models
{
    internal class Student
    {
        public static int Id;

        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }
        public byte Point { get; set; }
        




        public Student(string name, string surname, byte age, byte point)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Point = point;
            Id++;
        }
        public static bool operator >(Student p1, Student p2)
        {
            return p1.Point > p2.Point;
        }
        public static bool operator <(Student p1, Student p2)
        {
            return p1.Point < p2.Point;
        }
        public void ShowInfo()
        {

            Console.WriteLine($"Id: {Id}\n" +
                              $"Name: {Name}\n" +
                              $"Surname: {SurName}\n" +
                              $"Age: {Age}\n" +
                              $"Point: {Point}");
        }


    }
}
