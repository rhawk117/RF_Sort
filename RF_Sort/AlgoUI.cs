using System;

namespace RF_Sort
{
    public class AlgoUI
    {
        private const string MENU_TEXT = @"
            NOTE: During the review only Shell & Quick Sort were covered

            *==========================================================*    
            |                [ UI Made by rhawk117 ]                   |
            *==========================================================*
            | [ Algorithims & Print Methods Made By Professor Dowell ] |
            |      [ Algo Buddy - CSCI 3400: Data Structures ]         |
            |          [ Sorting Algorithm Visualizer ]                |
            |                                                          |
            |                                                          |
            |      [ Select a Sorting Algorithim to Visualize ]        |
            |                                                          |
            |            [ B ] - Bubble Sort                           |
            |            [ S ] - Selection Sort                        |
            |            [ I ] - Insertion Sort                        |
            |            [ Q ] - Quick Sort                            | 
            |            [ L ] - Shell Sort                            |
            |            [ M ] - Merge Sort                            |
            |            [ H ] - Heap Sort                             |
            |            [ E ] - Exit                                  |
            *==========================================================*
        ";

        private AlgoInfo activeUI;
        private static void menuText() => Console.WriteLine(MENU_TEXT);

        public AlgoUI()
        {
            activeUI = null;
        }

        public void RunUI()
        {
            Console.Clear();
            char choice;
            Console.WriteLine(MENU_TEXT);

            choice = char.ToLower(
                Console.ReadKey().KeyChar
            );

            if (choice != 'e')
            {
                handleKeys(choice);
            }
            else
            {
                Console.WriteLine("[ Thank you for using my program :> ]");
                Environment.Exit(0);
            }
        }
        private void handleKeys(char c)
        {
            switch (c)
            {
                case 'b':
                    setActiveWindow(new BubbleSort());
                    break;

                case 's':
                    setActiveWindow(new SelectionSort());
                    break;

                case 'i':
                    setActiveWindow(new InsertionSort());
                    break;

                case 'q':
                    setActiveWindow(new QuickSort());
                    break;

                case 'l':
                    setActiveWindow(new ShellSort());
                    break;

                case 'm':
                    setActiveWindow(new MergeSort());
                    break;

                case 'h':
                    setActiveWindow(new HeapSort());
                    break;

                default:
                    setActiveWindow(null, false);
                    break;
            }

        }

        private void setActiveWindow(AlgoInfo window, bool flag = true)
        {
            if (!flag || window == null)
            {
                Console.WriteLine("[ Select a valid option to proceed ]");
                RunUI();
            }
            else
            {
                activeUI = window;
                safeUI();

                activeUI = null;
                RunUI();
            }
        }

        private void safeUI()
        {
            try
            {
                activeUI.Run();
            }
            catch (StackOverflowException)
            {
                Console.WriteLine(@"
                That must of been a pain in the ass maxing out the stack frames
                
                Too bad the program accounted for this, you should be ashamed of yourself
                ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"
                An error occured while in the {activeUI}
                if this error persists and wasn't caused by intentional user
                error please reach out to me 

                ");
                Debug.errorCatch(ex);
            }
        }



    }
}
