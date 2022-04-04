using Generic_Collections.Models;
using System;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Natiq";
            string surname = "Agazada";
            byte age = 19;
            byte point = 50;
            Student stu1 = new Student(name, surname, age, point);
            stu1.ShowInfo();

            name = "Ismail";
            surname = "Qarayev";
            age = 20;
            point = 30;
            Student stu2 = new Student(name, surname, age, point);
            stu2.ShowInfo();

            name = "Seyfeddinaga";
            surname = "Abdullayev";
            age = 25;
            point = 70;
            Student stu3 = new Student(name, surname, age, point);
            stu3.ShowInfo();

            name = "Asif";
            surname = "Aliyev";
            age = 16;
            point = 26;
            Student stu4 = new Student(name, surname, age, point);
            stu4.ShowInfo();

            

            Console.WriteLine(stu1.Point > stu2.Point);

            




            Group gr = new Group();
            gr.Show();

            Group gr1 = new Group();
            gr.Show();

























        }





    }
}
