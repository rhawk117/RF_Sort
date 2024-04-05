using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF_Sort
{
    public static class Homework_10
    {

        private static List<int> shellSort = new List<int>
        {
            102, 13,  65,  68,  70,  2, 100,
            94,  29,  68,  108, 65,  86
        };

        private static List<int> quickSort = new List<int>
        {
            63,  74,  98,  71,  43,  42,  70 ,
            95 , 32  ,16 , 33,  66,  99,
        };

        public static void Part1()
        {
            List<int> gaps = new List<int> { 1, 3, 5 };
            Console.WriteLine("Pre-Array");
            //printArray(shellSort);
            Sort.ShellSort(shellSort, gaps);
            Console.WriteLine("Post-Array");
            //printArray(shellSort);
        }
        public static void Part2()
        {
            Console.WriteLine("Pre-Array");
            //printArray(quickSort);
            Console.WriteLine("_______________________________________________");
            Sort.QuickSort(quickSort, 4);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Post-Array");
            //printArray(quickSort);
        }







    }
}
