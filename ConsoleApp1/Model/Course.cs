using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model;

    internal class Course
    {
        public int course_id;
        public string course_title;
        public string course_description;
        public int course_code;

    public Course()
    {
    }

    public Course(  int course_id,
         string course_title,
         string course_description,
         int course_code)
        {
            this.course_id = course_id; 
            this.course_title = course_title;
            this.course_description = course_description; 
            this.course_code = course_code;
        }
        public Course Add()
        {
            Console.WriteLine("Enter Course_title :");
            course_title = Console.ReadLine();
            
            Console.WriteLine("Enter course_description :");
            course_description = Console.ReadLine();

            Console.WriteLine("Enter Course_code :");
            course_code = int.Parse(Console.ReadLine());

        return this;
        }
    public Course Edit()
    {
        Console.WriteLine("Edit Course_id :");
        course_id = int.Parse(Console.ReadLine());  

        Console.WriteLine("Edit Course_title :");
        course_title = Console.ReadLine();

        Console.WriteLine("Edit course_description :");
        course_description = Console.ReadLine();

        Console.WriteLine("Edit Course_code :");
        course_code = int.Parse(Console.ReadLine());

        return this;
    }
    public int Delete()
    {
        Console.WriteLine("Delete Course_id :");
        course_id = int.Parse(Console.ReadLine());

        return course_id;
    }
}

