using System;
using Microsoft.Data.SqlClient;
namespace Lecture21
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "Select * from person";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine($"id : {dr.GetValue(0)}, Name: {dr[1]}, Age: {dr.GetValue(2)}"); 
            }
            con.Close();
        }
    }
}
