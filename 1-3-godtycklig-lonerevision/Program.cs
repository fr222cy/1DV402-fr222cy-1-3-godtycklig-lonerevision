using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_godtycklig_lonerevision
{
    class Program
    {
        //Main-metoden (DEL 1)
        static void Main(string[] args)
        {

            while (true)
            {
                int amountOfSalaries = Readint("Enter the amount of Salaries: "); //
                // Om villkoret stämmer så går vi ner i metoden "processSalaries".
               
                if (amountOfSalaries >= 2)
                {
                    processSalaries(amountOfSalaries);
                   
                }
                   else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You need to enter atleast 2 salaries\n");

                    Console.ResetColor();
                    
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Press any key to make a new calculation. ESC exits\n");
                    Console.ResetColor();


                            }
                            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                return;
                            }
            }
            
        }
        //processSalaries-metoden (DEL 3)

        static void processSalaries(int count)
        {
            
              //Skapar nya arrayer.
              int[] IntArray = new int[count];
              int[] UnsArray = new int[count];

              for (int i = 0; i < count; i++)
              {
                  IntArray[i] = Readint("Enter Salary "  + (i+1) + " :" );
              }

              //Här sker uträkningarna för presentationen av resultatet.
              UnsArray = (int[])IntArray.Clone();
              Array.Sort(IntArray);
              int wageDistribution;
              int median;
              int calcMedian1;
              int calcMedian2;
              wageDistribution = (IntArray.Max() - IntArray.Min());

              if (count % 2 == 0)
              {
                  calcMedian1 = count / 2;
                  calcMedian2 = calcMedian1 - 1;
                  median = (IntArray[calcMedian1] + IntArray[calcMedian2]) / 2;
              }
              else
              {
                  median = IntArray[count / 2];
              }
              //Presentation av resultatet.
              Console.WriteLine(" ");
              Console.WriteLine("----------------------------");
              Console.WriteLine("Median Salary    : {0,10:c0}", median);
              Console.WriteLine("Average Salary   : {0,10:c0}", IntArray.Average());
              Console.WriteLine("Wage Distribution: {0,10:c0}", wageDistribution);
              Console.WriteLine("----------------------------");

                  for (int a = 0; a < count; a++)
                  {
                      if(a % 3 == 0)
                      {
                          Console.WriteLine();
                      }
                      Console.Write("{0,10}",UnsArray[a]);
                  }
             
              Console.WriteLine();
              Console.BackgroundColor = ConsoleColor.DarkGreen;
              Console.WriteLine("Press any key to make a new calculation. ESC exits\n");
              Console.ResetColor();
              
        }

        //ReadInt-metoden (DEL 2)
        static int Readint(string prompt)
        {

            while (true)
            {
                Console.Write(prompt);
                string UserInput;
                UserInput = Console.ReadLine();
                try
                {
                    int number = int.Parse(UserInput);
                    return number;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR! {0} Is not a valid number.\n", UserInput);
                    Console.ResetColor();
                   
                }
                
            }

        }

      
        }
    }

