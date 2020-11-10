using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFFEMASKINEN
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();


            while (true)
            {
                Console.WriteLine("\t1 - ON/OFF");
                Console.WriteLine("\t2 - Start");
                Console.WriteLine("\t3 - Fill liquid tank");
                Console.WriteLine("\t4 - Fill powder");
                Console.WriteLine("\t5 - Insert filter");
                Console.WriteLine("\t6 - Empty department");

                Console.Write("\nPower is");
                if (coffeeMachine.IsPower)
                {
                    Console.WriteLine(" ON");
                }
                else
                {
                    Console.WriteLine(" OFF");
                }

                if (coffeeMachine.Tank.Liquid != null)
                {
                    Console.WriteLine($"Liquid tank has {coffeeMachine.Tank.Amount}ml of {coffeeMachine.Tank.Liquid.GetType().Name.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Liquid tank is empty");
                }

                Console.Write("Filter is");
                if (coffeeMachine.Department.HasFilter())
                {
                    Console.WriteLine(" present");
                }
                else
                {
                    Console.WriteLine(" missing");
                }

                Console.Write("Department is");
                if (coffeeMachine.Department.HasPowder())
                {
                    Console.WriteLine($" filled with {coffeeMachine.Department.Powder.GetType().Name.ToLower()}");
                }
                else
                {
                    Console.WriteLine(" Empty");
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        coffeeMachine.SetPower();
                        break;
                    case ConsoleKey.D2:
                        if (coffeeMachine.IsPower)
                        {
                            Console.Clear();
                            Console.Write("How many cups will you make?: ");
                            int cups = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(coffeeMachine.MakeCoffee(cups));
                        }
                        else
                        {
                            Console.WriteLine("Power is not ON!");
                        }
                        wait();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("\t1 - Fill with water");
                        Console.WriteLine("\t2 - Fill with vodka");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine(coffeeMachine.Tank.Fill(new Water()));
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine(coffeeMachine.Tank.Fill(new Vodka()));
                                break;
                            default:
                                break;
                        }
                        wait();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("\t1 - Fill with coffe");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine(coffeeMachine.Department.Fill(new Coffee()));
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine(coffeeMachine.Department.Fill(new Tea()));
                                break;
                            default:
                                break;
                        }
                        wait();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine(coffeeMachine.Department.InsertFilter());
                        wait();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine(coffeeMachine.Department.Empty());
                        wait();
                        break;
                    default:
                        break;
                }


                Console.Clear();
            }
        }
        static void wait()
        {
            Console.WriteLine("\nPress any key to continue");

            Console.ReadKey(true);
        }
    }
}
