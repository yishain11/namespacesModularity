using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
public class BadClass
{
    List<string> studentNames = new List<string>();
    List<int> studentAges = new List<int>();
    List<string> courseNames = new List<string>();
    List<List<string>> studentCourses = new List<List<string>>();
    bool runApp = true;
    public void showMenu() {
        Console.WriteLine("Welcome to BadSchoolApp!");

        while (runApp)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add course");
            Console.WriteLine("3. Enroll student in course");
            Console.WriteLine("4. Show student details");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();
                studentNames.Add(name);

                Console.WriteLine("Enter student age:");
                int age = int.Parse(Console.ReadLine());
                studentAges.Add(age);

                studentCourses.Add(new List<string>());
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter course name:");
                string course = Console.ReadLine();
                courseNames.Add(course);
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter student index:");
                int studentIndex = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter course index:");
                int courseIndex = int.Parse(Console.ReadLine());

                studentCourses[studentIndex].Add(courseNames[courseIndex]);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter student index:");
                int studentIndex = int.Parse(Console.ReadLine());

                Console.WriteLine($"Name: {studentNames[studentIndex]}");
                Console.WriteLine($"Age: {studentAges[studentIndex]}");
                Console.WriteLine("Courses:");
                foreach (var course in studentCourses[studentIndex])
                {
                    Console.WriteLine(course);
                }
            }
            else if (choice == "5")
            {
                runApp = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
    

}