using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static int add(int number1,int number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            //  task1();
            // task2();
            // task3();
            // task4();
            // task5();
            // task6();
            // task7();
            // task8();
            // task9();
            // task10();
            //task11();
            //task12();
            //task13();
            int number1, number2;
            Console.WriteLine("Enter value of number 1");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of number 2");
            number2 = int.Parse(Console.ReadLine());
            int result = add(number1, number2);
            Console.WriteLine("Sum = {0}", result);
            Console.ReadKey();

        }
        static void task1()
        {
            Console.Write("Hello World!!");
            Console.Write("Hello World!!");
            //Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Hello World!!");
            Console.ReadKey();
        }
        static void task3()
        {
            int variable1 = 7;
            String var2 = "Welcome!";
            Char var3 = 'V';
            float var4 = 2.2F;
            Console.Write("Value=");
            Console.WriteLine(variable1);
            Console.Write("Here is the output of string:");
            Console.WriteLine(var2);
            Console.Write("Here is the output of Char:");
            Console.WriteLine(var3);
            Console.Write("Here is the output of float:");
            Console.WriteLine(var4);
            Console.ReadKey();
        }
        static void task4()
        {
            String input;
            Console.WriteLine("Enter value:");
            input = Console.ReadLine();
            Console.WriteLine("You have entered:");
            Console.WriteLine(input);
            Console.ReadKey();
        }
        static void task5()
        {
            string input;
            int number;
            Console.Write("Enter Value:");
            input = Console.ReadLine();
            number = int.Parse(input);
            Console.Write("You Have Entered:");
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void task6()
        {

            float number;
            Console.Write("Enter Value:");
            number = float.Parse(Console.ReadLine());
            Console.Write("You Have Entered:");
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void task7()
        {

            float length;
            float area;
            Console.Write("Enter length:");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is {0}", area);
            Console.ReadKey();
        }
        static void task8()
        {

            float marks;
            Console.Write("Enter Marks:");
            marks = float.Parse(Console.ReadLine());
            if (marks > 50)
            {
                Console.Write("You Have Passed.");
            }
            else if (marks <= 50)
            {
                Console.WriteLine("You Have failed");
            }

            Console.ReadKey();
        }
        static void task9()
        {
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("Welcome Laiba");
            }

            Console.ReadKey();
        }
        static void task10()
        {
            int sum = 0;
            int number;
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
            while (number != -1)
            {
                sum = sum + number;
                Console.WriteLine("Enter Number:");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum={0}", sum);

            Console.ReadKey();
        }
        static void task11()
        {
            int sum = 0;
            int number;
            do
            {
                Console.Write("Enter a number:");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != -1);
            Console.WriteLine("Enter Number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum={0}", sum);

            Console.ReadKey();



        }
        static void task12()
        {
            int[] number = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number {0}", i);
                number[i] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (number[i] > largest)
                {
                    largest = number[i];
                }
                Console.WriteLine("Largest {0}:", largest);
                Console.ReadKey();
            }
        }
        static void task13()
        {
            int age;
            int TotalMoney ;
            int toy_Price;
            int toy=0 ;
            int money=0;
            int even = 1;
            Console.Write("Enter age of lilly:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Money:");
             TotalMoney= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter toy Price:");
            toy_Price = int.Parse(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    money = money + (even * 10);
                    even++;
                    money = money - 1;
                }
                if (i % 2 != 0)
                {
                    toy = toy + 1;
                }
            }
                
                money = money + (toy*toy_Price);
                int left =  money-TotalMoney;
                if(money>TotalMoney)
                {
                    Console.Write("Yes {0}" ,left);
                }
                else
                {
                    Console.Write("No {0}", left);

                }
            
            Console.ReadKey();
        }
        static void task14()
        {
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("Welcome Laiba");
            }

            Console.ReadKey();
        }
    }
}
