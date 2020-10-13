using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
namespace Lecture16
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileManager.ManageFiles();

            Person p = new Person
            {
                Name = "Ali",
                Age = 12,
                Address = new Address
                {
                   City= "Lahore",
                   Country= "Pakistan",
                   ZIP=54000
                }
            };

            string jsonOutput = JsonSerializer.Serialize(p);
            Console.WriteLine(jsonOutput);
            File.WriteAllText("myfile.txt",jsonOutput);

            string jsonString = File.ReadAllText("myfile.txt");
            Person p2 = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(p2.Name);
        }
    }
}
