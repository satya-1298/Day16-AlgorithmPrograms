using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
                Console.WriteLine("3-BubbleSort");
                Console.WriteLine("4-Merge Sort");
                Console.WriteLine("5-Anagram");
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
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Display();
                        Console.WriteLine("****************************");
                        break;
                    case 4:
                        int[] num = new int[] { 5, 77, 3, 7, 19, 36, 11 };
                        int len = num.Length;   
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.SortMethod(num, 0, len - 1);
                        Console.WriteLine("Sorted list is ");
                        foreach(int i in num)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("******************************");
                        break;
                    case 5:
                        Anagram anagram = new Anagram();
                        anagram.Check();
                        Console.WriteLine("******************************");
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
