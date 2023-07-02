using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_task_SchoolManagementSystem
{
    internal class Student:Person
    {
        string Studentid;
        string Grade;
        string[] Courses;

        public Student(string Studentid, string Grade, string[] Courses, string Name, int Age, string Address) :base(Name,Age,Address)
        {
           this.Studentid = Studentid;
            this.Grade = Grade;
            this.Courses = Courses;
        }
        public void displayStudent()
        {
            Console.WriteLine($"student name: {Name} student age: {Age} student address: {Address} Studentid: {Studentid}  Grade {Grade} ");
            Console.WriteLine("courses are: ");
            for(int i = 0; i < Courses.Length; i++)
            {
                Console.WriteLine(Courses[i]);
            }
        }
    }
}
