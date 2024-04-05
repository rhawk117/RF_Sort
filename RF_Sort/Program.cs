﻿using System;
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
            AlgoUI Menu = new AlgoUI();
            Menu.RunUI();




            // Individual UIs (run individually)

            // For BubbleSort
            //Run(new BubbleSort());

            // For SelectionSort
            //Run(new SelectionSort());

            // For InsertionSort
            //Run(new InsertionSort());

            // For QuickSort
            //Run(new QuickSort());

            // For ShellSort
            //Run(new ShellSort());

            // For MergeSort
            //Run(new MergeSort());

            // For HeapSort
            //Run(new HeapSort());





        }

        static void Run(AlgoInfo activeWindow) => activeWindow.Run();




    }
}
