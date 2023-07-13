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
                Console.WriteLine("1-Two Strings are Equal or not");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        AlgorithmProg algorithmProg = new AlgorithmProg();
                        algorithmProg.Word();
                        break;
                }
            }
        }
    }
}
