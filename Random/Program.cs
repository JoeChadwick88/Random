using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rock = 1;
            int paper = 2;
            int scissors = 3;
            int user = 4;
            int score = 0;
            int ComputerScore = 0;


            while (user != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Computer " + ComputerScore);
                Console.WriteLine("You " + score);
                Random RNG = new Random();
                int Number = RNG.Next(1, 4);
                Console.WriteLine("press 1 for rock 2 for paper and 3 for scissors.(press 0 to exit)");
                user = int.Parse(Console.ReadLine());
                Task.Delay(800).Wait();
                

                if (Number == 1)
                {
                    

                    if (user == 1)
                    {
                        Console.WriteLine("computer choses rock");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("its a draw ");
                    }
                    else if (user == 2)
                    {
                        Console.WriteLine("computer choses rock");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you win");
                        score = score + 1;
                    }
                    else if (user == 3)
                    {
                        Console.WriteLine("computer choses rock");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you lose");
                        ComputerScore = ComputerScore + 1;
                    }
                    else if (user == 0)
                    {
                        break;
                    }
                }
                if (Number == 2)
                {
                    Task.Delay(800).Wait();
                    if (user == 2)
                    {
                        Console.WriteLine("computer choses paper");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("its a draw ");
                    }
                    else if (user == 1)
                    {
                        Console.WriteLine("computer choses paper");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you win");
                        score = score + 1;
                    }
                    else if (user == 3)
                    {
                        Console.WriteLine("computer choses paper");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you lose");
                        ComputerScore = ComputerScore + 1;
                    }
                    else if (user == 0)
                    {
                        break;
                    }
                }
                if (Number == 3)
                {
                    Task.Delay(800).Wait();
                    if (user == 3)
                    {
                        Console.WriteLine("computer choses scissors");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("its a draw ");
                    }
                    else if (user == 2)
                    {
                        Console.WriteLine("computer choses scissors");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you win");
                        score = score + 1;
                    }
                    else if (user == 1)
                    {
                        Console.WriteLine("computer choses scissors");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you lose");
                        ComputerScore = ComputerScore + 1;
                    }
                    else if (user == 0)
                    {
                        break;
                    }
                    
                }
            }
        }

    }
}
