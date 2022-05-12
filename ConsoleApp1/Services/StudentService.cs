using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class StudentService
    {
        string connectionString = @"Data Source=WAIANGDESK12;Initial Catalog=StudentManagement;Integrated Security=True";

        public void Add(Student s)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.Student_insert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@roll_no", s.roll_no));
                command.Parameters.Add(new SqlParameter("@stud_name", s.Stud_name));
                command.Parameters.Add(new SqlParameter("@Email", s.Email));
                command.Parameters.Add(new SqlParameter("@address", s.address));
                command.Parameters.Add(new SqlParameter("@course_id", s.course_id));



                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Add Student Successfully");
            }
        }

        public void Edit(Student s)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.student_update", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@stud_id", s.stud_id));
                command.Parameters.Add(new SqlParameter("@roll_no", s.roll_no));
                command.Parameters.Add(new SqlParameter("@Stud_name", s.Stud_name));
                //command.Parameters.Add(new SqlParameter("@Email", s.Email));
                command.Parameters.Add(new SqlParameter("@address", s.address));
                command.Parameters.Add(new SqlParameter("@course_id", s.course_id));


                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Edit Student Successfully");
            }
        }
        public void Delete(int stud_id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.student_delete", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@stud_id", stud_id));

                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Delete Course Successfully");
            }
        }
    }
}
