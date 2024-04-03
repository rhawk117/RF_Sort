using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF_Sort.AlgoView
{
    public static class GuidedUI
    {
        // ctor

        private const string SUMMARY = @"
            ==========================================================================
            |                         OVERVIEW                                       |
            ==========================================================================
         ";
        public static AlgoInfo bubbleSort()
        {
            string desc = @"
            
            |    Bubble Sort is one of the simplest sorting algorithms               |
            |    that works by repeatedly swapping the adjacent elements             |
            |    if they are in the wrong order.                                     |
            |                                                                        |
            |    This process is repeated until the list is sorted. Despite          |
            |    its simplicity, Bubble Sort is not efficient by any means for       |
            |    sorting method for large datasets due to its higher time complexity |
            |    in comparison to more advanced algorithms.                          |
            
            ";
            desc = SUMMARY + desc + timeComparsions(bst: "n", wst: "n^2", avg: "n^2");
            string[] steps = {
                "The algorithm compares the current element with the next element in the array.",
                "If the current element is greater than the next element, they are swapped with one another.",
                "This process is repeated for all elements, making multiple passes through the list.",
                "With each pass, the largest unsorted element and \"bubbles\" it up to the correct position at the end of the list."
            };
            // string title, string bigO, string description, string[] steps,
            // List<int> worstCaseInput, string explainWorst)

            AlgoInfo bubbleSort = new AlgoInfo(
                title: "Bubble Sort",
                bigO: "O(n^2)",
                description: desc,
                steps: steps,
                sort: Sort.BubbleSort,
                worstCaseInput: new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                explainWorst: "sorted in reverse order because the algorithm must make n-1 passes through the list to bubble each item."
            );
            return bubbleSort;
        }

        private static string timeComparsions(string bst, string wst, string avg)
        {
            string footer = $@"
            ==========================================================================                                                                 
            |    Best Case: O({bst})                                                 |
            |    Worst Case: O({wst})                                                |
            |    Average Case: O({avg})                                              |
            ==========================================================================
            ";
            return footer;
        }




    }
}
