using c_sharp_task_SchoolManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
      Person person=new Person("omran",27,"seeb");

        string[] Courses = { "math", "IT" };

        Student student = new Student("1121", "A", Courses, "omran", 27, "seeb");
        student.displayStudent();


    }
}