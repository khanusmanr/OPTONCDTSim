using System;
using System.IO;
using System.Collections.Generic;

namespace optoNCDTSim
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Book 1.csv";
            StreamReader reader = null; 
            
            if(File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<string> listA = new List<string>(); 
                while(!reader.EndOfStream){
                    var line = reader.ReadLine(); 
                    var values = line.Split(',');
                    if(line == null)
                    { 
                        values.RemoveEmptyEntries; 
                    }
                    foreach(var item in values)
                    { 
                        listA.Add(item); 
                    }
                    foreach (var coloumn1 in listA)
                    { 
                        Console.WriteLine(coloumn1); 
                    }
                }

            } 
            else{ 
                Console.WriteLine("File doesn't exist"); 
            }
            Console.ReadLine(); 
        }
    }
}
