using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandling.Models;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            string myfile = "..\\..\\myfile.txt";
            string directoryName = "..\\..\\Models";
            string[] listOfFiles;

            if (File.Exists(myfile))
            {
                Console.WriteLine("Created: " + File.GetCreationTime(myfile)); 
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            if (Directory.Exists(directoryName))
            {
                listOfFiles = Directory.GetFiles(directoryName);
                foreach (string file in listOfFiles)
                {
                    Console.WriteLine("   " + file);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }

            FileStream outFile = new FileStream("..\\..\\somefile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine("Hello World!");
            writer.Close();
            outFile.Close();
        }
    }
}
