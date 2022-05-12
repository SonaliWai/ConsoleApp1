using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class sample1
    {
        public void SampleStore()
        {
            string connectionString = @"Data Source=WAIANGDESK12;Initial Catalog=SampleStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            //2.command
            string queryString = "select * from production.products";
            SqlCommand command = new SqlCommand(queryString, connection);

            //3.reader
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());

            }
            reader.Close();
            connection.Close();
        }

        public void SampleStore2()
        {
            string connectionString = @"Data Source=WAIANGDESK12;Initial Catalog=SampleStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();

                SqlCommand command = new SqlCommand("testSP",connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@min_price", 10000));
                command.Parameters.Add(new SqlParameter("@max_price", 2000000));

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(reader[0].ToString()+" "+reader[1].ToString());
                }
            }

        }
    }

}
