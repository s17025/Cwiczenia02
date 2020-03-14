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
                string[] res;
                var hash = new HashSet<Student>(new OwnComparer()); ;

                
                foreach (var line in lines)
                {
                    res = line.Split(',');
                    if(line != string.Empty)
                    {
                        var stud = new Student
                        {
                            fname = res[0],
                            lname = res[1],
                            studiesName = res[2],
                            mode = res[3],
                            indexNumber = res[4],
                            birthdate = DateTime.Parse(res[5]),
                            email = res[6],
                            mothersName = res[7],
                            fathersName = res[8]

                        };
                        hash.Add(stud);
                    }
                    else
                    {
                        var log = res;
                        System.IO.File.WriteAllLines(@"D:\Szkoła\APBD\Cwiczenia02\Cw2\Cw2\Log\log.txt", log);
                    }
                        

                    
                }
                
                

                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("plik nie istnieje!");
                System.IO.File.WriteAllText(@"D:\Szkoła\APBD\Cwiczenia02\Cw2\Cw2\Log\log.txt", "Plik nie istnieje!");
            }
            

              


        }
    }
}
