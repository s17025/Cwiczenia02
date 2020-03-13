using System;
using System.Collections.Generic;
using System.IO;

namespace Cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var path = @"d:\szkoła\apbd\cwiczenia02\zajęcia 2\dane.csv";
                var stream = new StreamReader(File.OpenRead(path));
                var lines = File.ReadLines(path);

                foreach (var line in lines)
                {
                    var Stud = new Student
                    {

                    };

                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("plik nie istnieje!");
            }
            catch (IOException)
            {
                throw;
            }

            var hash = new HashSet<Student>(new OwnComparer());

            var stud1 = new Student
            {
                fname = "Jan",
                lname = "Kowalski",
                indexNumber = "12345"
            };

            var stud2 = new Student
            {
                fname = "Jan",
                lname = "Kowalski",
                indexNumber = "12345"
            };

            var stud3 = new Student
            {
                fname = "Tomasz",
                lname = "Nowak",
                indexNumber = "012345"
            };

            hash.Add(stud1);
            hash.Add(stud2);
            hash.Add(stud3);

            Console.WriteLine(hash.Count);   


        }
    }
}
