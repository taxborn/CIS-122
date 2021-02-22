// Created by Braxton Fair
// On 01/14/2021

using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student aStudent1 = new Student("Braxton", "Scott", "Fair", "pt0697kq", 42);
            Student aStudent2 = new Student("Mikhaila", "Marie", "Malone", "no1853ls", 152);
            Student aStudent3 = new Student("Mackenzie", "Renee", "Malone", "ja7538qr", 162);

            Instructor aInstructor1 = new Instructor("John", "Wilkes", "Booth", "jwb@cia.gov", 429);
            Section aSection1 = new Section("CIS 122", "2", "10:00 - 10:50", "Armstrong 0306", aInstructor1);

            aSection1.AddStudent(aStudent1);
            aSection1.AddStudent(aStudent2);
            aSection1.AddStudent(aStudent3);

            List<Student> aListOfStudents = new List<Student>();

            aListOfStudents.Add(aStudent1);
            aListOfStudents.Add(aStudent2);
            aListOfStudents.Add(aStudent3);

            foreach (var student in aListOfStudents)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine("\n");
            }

            Console.WriteLine("------------------------------------\n");

            Console.WriteLine(aSection1.ToString());
            Console.WriteLine(aSection1.GetClassList());

            Console.ReadKey(); // So the console hangs and waits for us to close it
        }
    }
}
