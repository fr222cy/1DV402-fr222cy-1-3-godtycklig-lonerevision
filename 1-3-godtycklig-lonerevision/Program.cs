using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_godtycklig_lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfSalaries = Readint("Enter the amount of Salaries");
            processSalaries(amountOfSalaries);

        }
        static void processSalaries(int count)
        {
            
              if (count <= 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!" );
                Console.ResetColor();
                return;
            }
              int[] array = new int[count];

              for (int i = 0; i < count; i++)
              {
                  Console.Write("Mata in lön nr{0}", i);
                  array[i] = int.Parse(Console.ReadLine());
                  
              }
              Console.WriteLine(array[3]);
        }

        static int Readint(string prompt)
        {
            Console.Write("Enter the amount of salaries: ");
            int amountOfSalaries = int.Parse(Console.ReadLine());
            return amountOfSalaries;
        }
    }
}
