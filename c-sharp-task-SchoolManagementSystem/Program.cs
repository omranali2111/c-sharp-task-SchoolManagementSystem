using c_sharp_task_SchoolManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
      Person person=new Person("omran",27,"seeb");

        string[] Courses = { "math", "IT" };
        Student student = new Student("1121", "A", Courses, "omran", 27, "seeb");
        student.displayStudent();

        Console.WriteLine("****************************************************");

        string[] subjects = { "math", "IT" };
        Teacher teacher = new Teacher("ali", 48, "muscat", "2332", subjects);
        teacher.displayTeacher();

        Console.WriteLine("****************************************************");

        Course course = new Course("A112", "Mathmatics", "teaching four level of math");
        course.assignTeacher(teacher);
        course.displayCourse();

    }
}