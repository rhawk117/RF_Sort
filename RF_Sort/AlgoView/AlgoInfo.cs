using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace RF_Sort
{
    public class AlgoInfo
    {
        protected string title; // name of 

        protected string bigO; // time complexity

        protected string description; // description of the algorithm

        protected string[] steps; // steps of the algorithm

        protected List<int> WorstCaseInput = new List<int>(); // worst case input for the algorithm

        protected Action<List<int>> Sorter; // sorting method

        protected string explainWorst; // explaination of the type of worst case input

        public AlgoInfo(string title, string bigO, string description, string[] steps,
        Action<List<int>> sort, List<int> worstCaseInput, string explainWorst)
        {
            this.title = title;
            this.bigO = bigO;
            this.description = description;
            this.steps = steps;

            Sorter = sort;

            WorstCaseInput = worstCaseInput;
            this.explainWorst = explainWorst;
        }

        public AlgoInfo()
        {

        }

        protected virtual void setInfo() { }


        protected void desc(string bst, string wst, string avg)
        {
            string summary = $@"
            ==========================================================================
                                       OVERVIEW                                       
            ==========================================================================
               {description}
            
            ==========================================================================  
                                    TIME COMPLEXITY
               
               [ Best Case ] => O({bst})
               [ Worst Case ] => O({wst})
               [ Average Case ] => O({avg})

            ==========================================================================
            ";
            WriteLine(summary);
        }

        protected virtual void ASCIIart() { }
        protected virtual void ViewDescription() { }
        public void ViewSteps()
        {
            WriteLine($"[ Steps for {title} ]");
            for (int i = 0; i < steps.Length; i++)
            {
                aStep(i);
            }
            WriteLine("[ i ]Steps Completed [ i ]");
        }
        private void aStep(int i)
        {
            WriteLine($"[ {i + 1}. ] {steps[i]} ");
            Thread.Sleep(3000);
        }

        public void ViewWorstCase()
        {
            ASCIIart();
            WriteLine($@"
                                WORST CASE INPUT ({title})         
            =======================================================================
            [ Worst Case Input for {title} is a collection that is {explainWorst}]

                        [ Example Worst Case Collection ]
            ");
            arrayTileView(WorstCaseInput);
            Utils.enterToContinue();
        }

        public void Run()
        {
            Clear();
            ASCIIart();
            menuText();

            char input = ReadKey().KeyChar;
            input = char.ToUpper(input);

            if (input != 'E') handleKeys(input);
        }

        public void menuText()
        {
            WriteLine($@"
                    [ {title.ToUpper()} ]
                
                [ D ] - View Description
                [ S ] - View Steps
                [ W ] - View Worst Case Input
                [ R ] - Run {title}
                [ E ] - Exit

            ====================================================================
            ");
        }
        private void handleKeys(char c)
        {
            switch (c)
            {
                case 'D':
                    Clear();
                    ViewDescription();
                    break;

                case 'S':
                    Clear();
                    ViewSteps();
                    break;

                case 'W':
                    ViewWorstCase();
                    break;

                case 'R':
                    Clear();
                    pickCollection();
                    break;

                default:
                    youAreNaughty();
                    break;
            }
            Utils.enterToContinue();
            Run();
        }

        private void youAreNaughty()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\a\a[ Select a valid option (silly) ]");
            ResetColor();
        }


        private void pickCollection()
        {
            WriteLine(@"
              ================================================================
              |    [ ? ] Select an option for the collection to sort [ ? ]   |
              |                                                              |
              |        [ 1 ] - Random Collection                             |
              |        [ 2 ] - Custom Collection                             |
              |        [ 3 ] - Worst Case Collection                         |
              |        [ 4 ] - Exit                                          |
              ================================================================
            ");
            char input = ReadKey().KeyChar;
            if (input == '4') return;

            else getCollection(input);

        }
        private void getCollection(char input)
        {
            List<int> collection = new List<int>();
            switch (input)
            {
                case '1':
                    collection = Utils.GenerateRandom();
                    break;

                case '2':
                    collection = Utils.GetUserCollection();
                    break;

                case '3':
                    collection = WorstCaseInput;
                    break;

                default:
                    collection = null;
                    break;
            }
            if (collection == null)
            {
                youAreNaughty();
                pickCollection();
            }
            else
            {
                sortCollection(collection);
            }
        }

        private void sortCollection(List<int> list)
        {
            WriteLine($"[ Pre-{title} | Unsorted Array View ]\n");
            arrayTileView(list);
            Utils.enterToContinue();

            Sorter(list);

            WriteLine($"[ {title} Sort Complete | Sorted Array View ]\n");
            arrayTileView(list);
        }

        private void arrayTileView(List<int> collection)
        {
            WriteLine("[<index>] (<value>)");
            Write("|");
            for (int i = 0; i < collection.Count; i++)
            {
                Write($" [{i}] ({collection[i]})| ");
            }
            WriteLine();
        }

        // lol actions is better i just had a bruh moment trying to use the ctor 

        //private void detrSort(List<int> l)
        //{
        //    switch(title)
        //    {
        //        case "Bubble Sort":
        //            Sort.BubbleSort(l);
        //            break;

        //        case "Selection Sort":
        //            Sort.SelectionSort(l);
        //            break;

        //        case "Insertion Sort":
        //            Sort.InsertionSort(l);
        //            break;

        //        case "Quick Sort":
        //            Sort.QuickSort(l);
        //            break;

        //        case "Merge Sort":
        //            Sort.MergeSort(l);
        //            break;

        //        case "Heap Sort":
        //            Sort.Heapsort(l);
        //            break;

        //        default:
        //            throw new 
        //    }
        //}




    }
}
