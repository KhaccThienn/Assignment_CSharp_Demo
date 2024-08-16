using Assignment_CSharp_Demo.Entities;
using Assignment_CSharp_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_CSharp_Demo.Implements
{
    public class StudentService : IStudent
    {
        private List<Student> students = new List<Student>();

        public void Display()
        {
            // Display the list of students
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id} \n" +
                    $"Name: {student.Name}\n" +
                    $"Math: {student.MathScore}\n" +
                    $"Physics: {student.PhyScore}\n" +
                    $"Chemistry: {student.CheScore}");
            }
        }

        public void InputData()
        {
            // Input student data
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Math Score: ");
            double mathScore = double.Parse(Console.ReadLine());

            Console.Write("Enter Physics Score: ");
            double phyScore = double.Parse(Console.ReadLine());

            Console.Write("Enter Chemistry Score: ");
            double cheScore = double.Parse(Console.ReadLine());

            // Add new student to the list
            students.Add(new Student(id, name, mathScore, phyScore, cheScore));
            Console.WriteLine("Student added successfully!");
        }

        public List<Student> Search(double n, double m)
        {
            // Search for students whose math score is between n and m
            var result = students.Where(s => s.MathScore >= n && s.MathScore <= m).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine($"No students found with math scores between {n} and {m}.");
            }

            return result;
        }

        public List<Student> Search(string name)
        {
            // Search for students by name (case-insensitive)
            var result = students.Where(s => s.Name.Contains(name)).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine($"No students found with the name {name}.");
            }

            return result;
        }
    }
}
