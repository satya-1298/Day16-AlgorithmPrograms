using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mime;

namespace AlgorithmDemo
{
    public class AlgorithmProg
    {
        public void Word()
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            string path= "C:\\Users\\PC\\Desktop\\RFP288-Assignment\\Day16-AlgorithmPrograms\\AlgorithmDemo\\File.txt";
            string read =File.ReadAllText(path);
            //string[] word =read.Split(" ");
            string[] word = read.Split(' ');
            foreach (string str in word)
            {
                Console.WriteLine(str);
                

            }
            foreach (string str in word)
            {

                if (text == str)
                {
                    Console.WriteLine("Word found");
                }
                else { Console.WriteLine("Word not found"); }
            }


        }
    }
}
