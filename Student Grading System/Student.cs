using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Student
    {
        private string _name { get; set; }
        private List<double> _grades { get; set; }

        public Student(string Name, List<double> Grades)
        {
            this.Name = Name;
            this.Grades = Grades;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<double> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }


    }
}
