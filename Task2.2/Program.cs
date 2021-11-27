using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n / 10)
            {
                case 2:
                    {
                        Console.Write("двадцать");
                        break;
                    }
                case 3:
                    {
                        Console.Write("тридцать");
                        break;
                    }
                case 4:
                    {
                        Console.Write("сорок");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пятьдесят");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шестьдесят ");
                        break;
                    }
                default:
                    {
                        Console.Write("ошибка");
                        break;
                    }
            }
            Console.Write(" ");
            if (n % 10 == 0 || n % 10 >= 5)

            {
                switch (n % 10)
                {
                    case 5:
                        {
                            Console.Write("пять");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шесть");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семь");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемь");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девять");
                            break;
                        }
                }
                Console.Write(" ");
                Console.Write("лет.");
            }
            else if (n % 10 == 1)
            {
                Console.Write("один");
                Console.Write(" ");
                Console.Write("год.");
            }
            else // if (n % 10>=2) // 2,3,4
            {
                switch (n % 10)
                {
                    case 2:
                        {
                            Console.Write("два");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("три");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("четыре");
                            break;
                        }
                }
                Console.Write(" ");
                Console.Write("года.");
            }
            Console.ReadKey();




        }

              
            }

        }
   
