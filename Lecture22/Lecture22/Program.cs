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
            //Console.Write("Enter Password");
            //string pwd = Console.ReadLine();

            //string query = "insert into Users(UserName, Password) values('admin','123')";
            //string query = $"insert into Users(UserName, Password) values('{userName}','{pwd}')";
            //string query = $"Update  Users set Password ='{pwd}' where username  = '{userName}'";
            string query = $"delete from  Users where username  = '{userName}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            int insertedRows = cmd.ExecuteNonQuery();
            if (insertedRows >= 1)
            {
                Console.WriteLine("row inserted/updated/deleted");

            }
            else {
                Console.WriteLine("failed");

            }
            connection.Close();
        }
    }
}
