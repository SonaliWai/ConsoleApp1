// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Model;
using ConsoleApp1.Services;

Console.WriteLine("Hello, World!");

//sample1 s = new sample1();
//s.SampleStore();
//s.SampleStore2();
CourseService courseService = new CourseService();
Course course = new Course();

StudentService studentService = new StudentService();
Student student = new Student();

SubjectService subjectService = new SubjectService();
Subject subject = new Subject();
//CourseService a = new CourseService();

Console.WriteLine("1.Add Course");
Console.WriteLine("2.Edit course");
Console.WriteLine("3.Delete course");
Console.WriteLine("4.Add Student");
Console.WriteLine("5.Edit Student");
Console.WriteLine("6.delete Student");
Console.WriteLine("7.Add Subject");
Console.WriteLine("8.Edit Subject");
Console.WriteLine("9.Delete Subject");



do
{
    Console.Write("Enter your choice");
    var EnterNumber = int.Parse(Console.ReadLine());

    switch (EnterNumber)
    {
        case 1:
            courseService.Add(course.Add());
            break;
        case 2:
            courseService.Edit(course.Edit());
            break;
        case 3:
            courseService.Delete(course.Delete());
            break;
        case 4:
            studentService.Add(student.Add());
            break;
        case 5:
            studentService.Edit(student.Edit());
            break;
        case 6:
            studentService.Delete(student.Delete());
            break;
        case 7:
            subjectService.Add(subject.Add());
            break;
        case 8:
            subjectService.Edit(subject.Edit());
            break;
        case 9:
            studentService.Delete(subject.Delete());
            break;

        default:
            if (EnterNumber == 0)
                Environment.Exit(0);
            else
                Console.WriteLine("wrong field");
            break;
    }
}
while (true);
            

   
     


