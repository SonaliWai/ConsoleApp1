using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class SubjectService
    {
        string connectionString = @"Data Source=WAIANGDESK12;Initial Catalog=StudentManagement;Integrated Security=True";

        public void Add(Subject s)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.Sub_insert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                
                command.Parameters.Add(new SqlParameter("@sub_title", s.sub_title));
                command.Parameters.Add(new SqlParameter("@sub_description", s.sub_description));
                command.Parameters.Add(new SqlParameter("@course_id", s.course_id));
                command.Parameters.Add(new SqlParameter("@subject_code", s.subject_code));



                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Add Subject Successfully");
            }
        }
        public void Edit(Subject s)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.subject_update", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@sub_id", s.sub_id));
                command.Parameters.Add(new SqlParameter("@sub_title", s.sub_title));
                command.Parameters.Add(new SqlParameter("@sub_description", s.sub_description));
                command.Parameters.Add(new SqlParameter("@course_id", s.course_id));
                command.Parameters.Add(new SqlParameter("@subject_code", s.subject_code));


                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Edit Subject Successfully");
            }
        }
        public void Delete(int sub_id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.Subject_delete", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@sub_id", sub_id));

                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Delete Subject Successfully");
            }
        }
    }
}
