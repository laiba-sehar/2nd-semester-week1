using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace signUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path =@"C:\just for practice\file.txt";
 
             string[] name = new string[50];
            string[] password = new string[50];
            int option;
            do
            {
                readData(path, name, password);
                option = MainMenu();
                if (option == 1)
                {

                    Console.WriteLine("Enter name");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string p = Console.ReadLine();

                    signIn(n, p, name, password);
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string p = Console.ReadLine();
                    signUp(path , n , p );
                }

            }
            while (option > 3);
             Console.ReadLine();
        }
        static int MainMenu()
        {
            int option;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("3.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void signUp(string path,int n,int p)
        {
            StreamWriter variable = new StreamWriter(path,true);
            variable.WriteLine(n + "," + p);
            variable.Flush();
            variable.Close();
        }
        static void signIn(string n,string p,string[] name,string[] password)
        {
            bool flag=false;
            for(int i=0;i<50;i++)
            {
                if(n==name[i]&&p==password[i])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
                
            }
            if(flag==false)
            
                {
                    Console.WriteLine("Invalid User");
                }
            Console.ReadLine();


        }
        static string parseData(int field,string record)
        {
            int comma = 1;
            string item = "";
            for(int i=0;i<record.Length;i++)
            {
                if(record[i]==',')
                {
                    comma++;
                }
                else if(field==comma)
                    {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void readData(string path,string[] name,string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine())!= null)
                {
                    name[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 50)
                    {
                        break;
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
    }
}
