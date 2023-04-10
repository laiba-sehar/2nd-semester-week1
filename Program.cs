using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
           // task2();
            //task3();
            task5();

        }
        static void task1()
        {
            string path = "D:\\New folder\\textfile.txt";
            StreamWriter variable = new StreamWriter(path);
            variable.WriteLine("hello to the future");
            variable.WriteLine("My name is laiba");
            variable.WriteLine("I am the best");
            variable.Flush();
            variable.Close();
            Console.ReadLine();

        }
        static void task2()
        {
            string path = "D:\\New folder\\newfile.txt";
            if (File.Exists(path))
            {
                StreamReader variable = new StreamReader(path);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                variable.Close();
            }
            else
            {
                Console.WriteLine("Not exist");
            }
            Console.ReadLine();

        }
        static void task3()
        {
            string path = "D:\\New folder\\newfile.txt";
                StreamReader variable = new StreamReader(path);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                variable.Close();
            Console.ReadLine();
            
           
        }
        static void task5()
        {
            string path = "D:\\2\\newfile.txt";
            StreamWriter variable = new StreamWriter(path);
            variable.WriteLine("Hello!");
            variable.Flush();
            variable.Close();
            Console.ReadLine();

        }

    }
}
