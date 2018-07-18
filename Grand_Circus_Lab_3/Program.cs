using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Circus_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("What's your name: ");
            string name = Console.ReadLine();
          
            while (true)
            {
                Console.Write("Give me a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());
                if (number <= 100 && number >= 0)
                {
                    string yes;
                    if ((number % 2) == 1)
                    {
                        Console.WriteLine($"{name} {number} is Odd");
                        Console.Write("do you still want to continue? (y/n)");
                        yes = Console.ReadLine();
                        if (yes.ToLower() == "n")
                        {
                            break;
                        }
                        if (number >= 60)
                        {
                            Console.WriteLine($"{name} your number is Odd");
                            Console.Write("do you still want to continue? (y/n)");
                            yes = Console.ReadLine();
                            if (yes.ToLower() == "n")
                            {
                                break;
                            }
                        }
                    }
                    else if ((number % 2) == 0)
                    {
                        if (number >= 2 && number <= 25)
                        {
                            Console.WriteLine($"{name} {number} is Even and less than 25");
                            Console.Write("do you still want to continue? (y/n)");
                            yes = Console.ReadLine();
                            if (yes.ToLower() == "n")
                            {
                                break;
                            }
                        }
                        else if (number >= 26 && number <= 60)
                        {
                            Console.WriteLine($"{name} your number is Even");
                            Console.Write("do you still want to continue? (y/n)");
                            yes = Console.ReadLine();
                            if (yes.ToLower() == "n")
                            {
                                break;
                            }
                        }
                        else if (number > 60)
                        {
                            Console.WriteLine($"{name} {number} is Even");
                            Console.Write("do you still want to continue? (y/n)");
                            yes = Console.ReadLine();
                            if (yes.ToLower() == "n")
                            {
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine($"{name} your number is Even");
                            Console.Write("do you still want to continue? (y/n)");
                            yes = Console.ReadLine();
                            if (yes.ToLower() == "n")
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Gotta be between 1 and 100");
                }
            }
        }
    }
}
