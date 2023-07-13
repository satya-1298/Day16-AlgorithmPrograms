using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class InsertionSort
    {
        public void Display()

        {
            string[] str = { "m", "u", "a","r" };
            int s = str.Length;
            for (int i = 0; i < s; i++)
            {
                string temp = "";
                for (int j = i + 1; j < s; j++)
                {

                    if (str[i].CompareTo(str[j]) > 0)
                    {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }

                }
            }
            Console.WriteLine("The sorted list is ");
            foreach (string d in str)
            {
                Console.WriteLine(d);
            }

        }
    }
}
