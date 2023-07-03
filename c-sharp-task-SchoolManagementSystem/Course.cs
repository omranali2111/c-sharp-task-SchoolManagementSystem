using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_task_SchoolManagementSystem
{
    internal class Course
    {
        string CoursId;
        string Title;
        string Description;
        public Teacher Teacher;
        

        public Course(string CoursId, string Title, string Description) 
        { 
            this.CoursId = CoursId;
            this.Title = Title;
            this.Description = Description;
            

        }

        public void displayCourse()
        {
            Console.WriteLine($"CoursId: {CoursId} course title: {Title} Description: {Description} ");
            Console.WriteLine("the course is assign with:");
            Teacher.displayTeacher();
        }

        public void assignTeacher(Teacher assignT)
        {
          Teacher= assignT;
        }
    }
}
