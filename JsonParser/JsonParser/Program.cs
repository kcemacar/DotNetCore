using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonParser
{
    class Program // First download Newtonsoft.Json
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Kutay",
                Degree = "MCA",
                Hobbies = new List<string>()
                {
                    "Reading",
                    "Playing Games"
                }
            };

            string strResultJson = JsonConvert.SerializeObject(student);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("Stored ! ");

            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"student.json");
            Student resultstudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(resultstudent.ToString());
            
        }
    }
}
