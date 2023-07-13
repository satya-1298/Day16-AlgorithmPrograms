using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class Anagram
    {
        public void Check()
        {

            string str1 = "Earth";
            string str2 = "heart";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Console.WriteLine("Before sorting \n"+str1 +"\n"+ str2);
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("******************************");
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            if (val1 == val2)
            {
                Console.WriteLine("It is an Anagram");
            }
            else
            {
                Console.WriteLine("Not an anagram");
            }
        }
    }
}
