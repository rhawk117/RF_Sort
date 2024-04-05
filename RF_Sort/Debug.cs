using System;
using System.Collections.Generic;

namespace RF_Sort
{
    public static class Debug
    {
        public static void UI()
        {
            AlgoUI ui = new AlgoUI();
            ui.RunUI();
        }
        public static void DoTest(Action aTest)
        {
            try
            {
                aTest();
            }
            catch (Exception ex)
            {
                errorCatch(ex);
            }
        }

        public static void errorCatch(Exception ex)
        {
            Console.WriteLine($"[!] {ex.Message} [!]");
            Utils.enterToContinue();

            Console.WriteLine($"\n\n Stack Trace: {ex.StackTrace}");
            Utils.enterToContinue();


            Console.WriteLine($"\n\nException Info\n\n {ex}");
            Utils.enterToContinue();
        }

        public static void uTestCollection()
        {
            List<int> c = Utils.GetUserCollection();
            Console.Write("{");
            foreach (int i in c)
            {
                Console.Write(i + ",");
            }
            Console.Write("}");
        }


    }
}
