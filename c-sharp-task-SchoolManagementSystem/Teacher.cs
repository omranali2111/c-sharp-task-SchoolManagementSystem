using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_task_SchoolManagementSystem
{
    internal class Teacher:Person
    {
        string teacherid;
        string[] subjects;

        public Teacher(string Name, int Age, string Address,string teacherid, string[] subjects):base(Name,Age,Address)
        {
            this.teacherid = teacherid;
            this.subjects = subjects;
        }
        public void displayTeacher()
        {
            Console.WriteLine($"teacher name: {Name} teacher age: {Age} teacher address: {Address} teacherid: {teacherid} ");
            Console.WriteLine("teaching subjects:");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }
    }
}
