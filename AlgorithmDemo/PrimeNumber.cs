using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public  class PrimeNumber
    {
        public void Display()
        {

            Console.Write("Enter The Start Number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {start} and {end} are : ");
            for (int i = start; i <= end; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                        Console.WriteLine("\n");
                    }

                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
