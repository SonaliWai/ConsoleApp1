using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Student
    {
        public int stud_id;
        public int roll_no;
        public string Stud_name;
        public string Email;
        public string address;
        public int course_id;

        public Student()
        {
        }

        public Student(
              int stud_id,
              int roll_no,
              string Stud_name,
              string Email,
              string address,
              int course_id)
    {
        this.stud_id = stud_id;
        this.roll_no = roll_no;
        this.Stud_name = Stud_name;
        this.Email = Email;
        this.address = address;
        this.course_id = course_id;
    }

        public Student Add()
        {
         

            Console.WriteLine("Enter roll_no :");
            roll_no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Stud_name :");
            Stud_name = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            Email = Console.ReadLine();

            Console.WriteLine("Enter address :");
            address = Console.ReadLine();

            Console.WriteLine("Enter course_id :");
            course_id = int.Parse(Console.ReadLine());

            return this;
        }
        public Student Edit()
        {
            Console.WriteLine("Enter Stud_id :");
            stud_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit roll_no :");
            roll_no = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit Stud_name :");
            Stud_name = Console.ReadLine();

            //Console.WriteLine("Edit Email :");
            //Email = Console.ReadLine();

            Console.WriteLine("Edit address :");
            address = Console.ReadLine();

            Console.WriteLine("Edit course_id :");
            course_id = int.Parse(Console.ReadLine());

            return this;
        }
        public int Delete()
        {
            Console.WriteLine("Delete Stud_id :");
            stud_id = int.Parse(Console.ReadLine());

            return stud_id;
        }
    }


}
