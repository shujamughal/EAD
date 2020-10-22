using System;
using Microsoft.Data.SqlClient;
namespace Lecture22
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNewDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();
           // Console.Write("Enter Password: ");
           // string pwd = Console.ReadLine();


            /*string query = $"select * from users " +
                $"where username = @u and password = @p";*/
            /*string query = $"insert into users (username, password)" +
                $"  values(@u,@p)";//*/
            //string query = $"update users set password=@p where username=@u";
            string query = $"delete from users where username=@u";
            SqlParameter p1 = new SqlParameter("u", userName);
            //SqlParameter p2 = new SqlParameter("p", pwd);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
           // cmd.Parameters.Add(p2);
            connection.Open();
            cmd.ExecuteNonQuery();
            /*SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Console.WriteLine("User Authenticated");
            }
            else {
                Console.WriteLine("Invalid User name or Password");
            }*/

            connection.Close();
        }
    }
}
