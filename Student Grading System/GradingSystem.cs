using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class GradingSystem
    {

        internal void DisplayGradingInfo(List<Student> students,
           Func<List<double>,double> calcAverage,
           Predicate<double> checkIfPassed,
           Action<Student,double, string> displayData) {

            foreach (Student student in students) {
                double avargeGrades = calcAverage(student.Grades);
                bool isStudentPassed = checkIfPassed(avargeGrades);
                string status = "Failed";
                if (isStudentPassed) status = "Passed";
                displayData(student,avargeGrades, status);
            }
        
        }
    }
}
