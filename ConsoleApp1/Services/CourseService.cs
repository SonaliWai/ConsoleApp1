using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class CourseService
    {
        string connectionString = @"Data Source=WAIANGDESK12;Initial Catalog=StudentManagement;Integrated Security=True";

        public void Add(Course c)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.Course_insert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@course_code",c.course_code));
                command.Parameters.Add(new SqlParameter("@course_title",c. course_title));

                command.Parameters.Add(new SqlParameter("@course_description", c.course_description));

                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n"+rowaffected+ "Add Course Successfully");
            }
        }
        public void Edit(Course c)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.Course_update", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@course_id", c.course_id));
                command.Parameters.Add(new SqlParameter("@course_code", c.course_code));
                command.Parameters.Add(new SqlParameter("@course_title", c.course_title));
                command.Parameters.Add(new SqlParameter("@course_description", c.course_description));
                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Edit Course Successfully");
            }
        }
        public void Delete(int course_id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);

            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.Course_delete", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@course_id", course_id));
                
                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowaffected + "Delete Course Successfully");
            }
        }
    }
}
