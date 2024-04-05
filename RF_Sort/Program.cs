using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Homework10.Part2();
        }

        static void uTestCollection()
        {
            List<int> c = Utils.GetUserCollection();
            Console.Write("{");
            foreach (int i in c)
            {
                Console.Write(i + ",");
            }
            Console.Write("}");
        }
        static void uTestUI()
        {
            BubbleSort bubble = new BubbleSort();
            bubble.Run();
        }


    }
}
