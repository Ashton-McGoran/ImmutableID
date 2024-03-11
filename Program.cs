using System;
using System.Collections.Generic;

namespace immutableID
{
    class Student
    {
        // Auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }

        // Parameterized constructor with ID only
        public Student(int id)
        {
            Id = id;
            FirstName = "";
            LastName = "";
        }

        // Parameterized constructor
        public Student(int id, string first, string last)
        {
            Id = id;
            FirstName = first;
            LastName = last;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students to add: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEnter information for Student {i + 1}:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                students.Add(new Student(id, firstName, lastName));
            }

            // Display information for all students
            Console.WriteLine("\nStudent Information:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine();
            }

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}
