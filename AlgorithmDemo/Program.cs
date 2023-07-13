using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.WriteLine("Choose a Option");
                Console.WriteLine("****************************");
                Console.WriteLine("1-Two Strings are Equal or not");
                Console.WriteLine("2-InsertionSort");
                Console.WriteLine("****************************");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        AlgorithmProg algorithmProg = new AlgorithmProg();
                        algorithmProg.Word();
                        Console.WriteLine("****************************");
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        sort.Display();
                        Console.WriteLine("****************************");
                        break;
                }
            }
        }
    }
}
