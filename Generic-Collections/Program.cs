using Generic_Collections.Models;
using System;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            string surname;
            byte age;
            byte point;

            Console.Write("Please enter student name: ");
            name = Console.ReadLine();

            Console.Write("Please enter student surname: ");
            surname = Console.ReadLine();

            Console.Write("Please enter student age: ");
            age = Convert.ToByte(Console.ReadLine());

            Console.Write("Please enter student point: ");
            point = Convert.ToByte(Console.ReadLine());

            Student stu1 = new Student(name, surname, age, point);
            stu1.ShowInfo();



            Console.Write("Please enter student name: ");
            name = Console.ReadLine();

            Console.Write("Please enter student surname: ");
            surname = Console.ReadLine();

            Console.Write("Please enter student age: ");
            age = Convert.ToByte(Console.ReadLine());

            Console.Write("Please enter student point: ");
            point = Convert.ToByte(Console.ReadLine());

            Student stu2 = new Student(name, surname, age, point);
            stu2.ShowInfo();

            Console.WriteLine(stu1.Point > stu2.Point);


            Console.WriteLine("Task 1.2 Group Class");

            
            
            
            
            
            
            
          



















        }





    }
}
