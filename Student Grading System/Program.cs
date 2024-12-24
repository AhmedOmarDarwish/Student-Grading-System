
using System.Collections.Generic;

namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                //Get User Name
                Console.WriteLine("Welcome, to Grading System!");
                Console.Write("Please Enter your Name:");
                string studentName = Console.ReadLine();
                Console.WriteLine($"Hi {studentName}");

                //Create List For Save 5 Subjects
                List<double> studentGrades = new List<double>();
                Console.WriteLine("Please Enter your Grades:(5 Subjects)");

                for (int i = 0; i < 5; i++)
                {
                    while (true)
                    {
                        Console.Write($"Subjects({i + 1}): ");
                        try
                        {

                            double gradeValue = double.Parse(Console.ReadLine());
                            studentGrades.Add(gradeValue);
                            break; // Exit the loop if parsing is successful
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                    }
                }

                //Create Object from Student To added Into List
                Student student = new Student(studentName, studentGrades);
                students.Add(student);
                Console.WriteLine($"A New Student Added to the system with Name {studentName}");

                //Continue Added or Not
                Console.WriteLine("Do You Want to Add New Student Y or N");
                char result = char.Parse(Console.ReadLine().ToLower());
                if (result == 'n')
                    break;
            }
            //Sum Avrage and Check if Student Pass or Failed 
            GradingSystem gradingSystem = new GradingSystem();
            gradingSystem.DisplayGradingInfo(
                students, gradeList => gradeList.Sum() / gradeList.Count,
                avg => avg >= 50,
                (student,avrGrade, status) => Console.WriteLine($"The User Name is {student.Name}, Avrage Grade is {avrGrade} and Status is {status}"));
        }

    }
}
