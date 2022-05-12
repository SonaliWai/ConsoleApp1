using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Subject
    {
        public int sub_id;
        public string sub_title;
        public string sub_description;
        public int course_id;
        public string subject_code;

        public Subject()
        {
        }

        public Subject(
             int sub_id,
             string sub_title,
             string sub_description,
             int course_id,
             string subject_code)
        {
            this.sub_id = sub_id;
            this.sub_title = sub_title;
            this.sub_description = sub_description;
            this.course_id = course_id;
            this.subject_code = subject_code;


        }
        public Subject Add()
        {


            Console.WriteLine("Enter sub_title :");
            sub_title = Console.ReadLine();

            Console.WriteLine("Enter sub_description:");
            sub_description = Console.ReadLine();

            Console.WriteLine("Enter course_id :");
            course_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject_code :");
            subject_code =Console.ReadLine();

            return this;
        }
        public Subject Edit()
        {
            Console.WriteLine("Enter sub_id :");
            sub_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit sub_title:");
            sub_title = Console.ReadLine();

            Console.WriteLine("Edit sub_description :");
            sub_description = Console.ReadLine();

            Console.WriteLine("Edit course_id :");
            course_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit subject_code :");
            subject_code = Console.ReadLine();

            return this;
        }
        public int Delete()
        {
            Console.WriteLine("Delete sub_id :");
            sub_id = int.Parse(Console.ReadLine());

            return sub_id;
        }

    }
}
