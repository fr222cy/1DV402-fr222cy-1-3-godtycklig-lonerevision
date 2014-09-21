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
              int[] IntArray = new int[count];
                
              for (int i = 0; i < count; i++)
              {
                  Console.Write("Mata in lön nr {0}: ", i +1);
                  IntArray[i] = int.Parse(Console.ReadLine());
                  
              }
              
              Array.Sort(IntArray);
              Console.WriteLine("Here are all your Salaries");
              foreach (int i in IntArray)
              {
                  
                  Console.WriteLine(i);
              }
              int wageDistribution;
              wageDistribution = (IntArray.Max() - IntArray.Min());

              
              

              Console.WriteLine(" ");
              Console.WriteLine("-----------------");
              Console.WriteLine("Medianlön:");
              Console.WriteLine("Medellön: {0}", IntArray.Average());
              Console.WriteLine("Lönespridning: {0}", wageDistribution);
              Console.WriteLine("-----------------");
        }

        static int Readint(string prompt)
        {
            Console.Write("Enter the amount of salaries: ");
            int amountOfSalaries = int.Parse(Console.ReadLine());
            return amountOfSalaries;
        }

        public static int GetMedian(int[] Value)
        {
            decimal Median = 0;
            int size = Value.Length;
            int mid = size / 2;
            Median = (size % 2 != 0) ? (decimal)Value[mid] : ((decimal)Value[mid] + (decimal)Value[mid + 1]) / 2;
            return Convert.ToInt32(Math.Round(Median));
        }
    }
}
