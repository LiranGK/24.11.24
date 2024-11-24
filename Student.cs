using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kys
{
    public class Student
    {
        private int id;
        public string name;
        private char gender;
        public string kita;
        private int grade;
        public Student(int id, string name, char gender, string kita)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.kita = kita;
            this.grade = -1;
        }
        public void SetGrade(int grade)
        {
            this.grade = grade;
        }
        public override string ToString()
        {
            string write;
            if (this.gender > -1)
            {
                write = "name: " + this.name + " ,id: " + this.id + " ,gender: " + gender + " ,kita: " + kita + " ,grade: " + grade;
            }
            else
            {
                write = "name: " + this.name + " ,id: " + this.id + " ,gender: " + gender + " ,kita: " + kita + " ,grade: yet to be graded";
            }
            return write;
        }
        public bool BestGrade(Student other)
        {
            return this.grade>other.grade;
        }
    }
}
