﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RF_Sort
{
    public static class Utils
    {
        public static List<int> GenerateRandom(int size = 20, int min = 1, int max = 101)
        {
            List<int> list = new List<int>(size);
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(min, max));
            }
            return list;
        }

        public static List<int> GetUserCollection()
        {
            Console.Write(@"
            [ ? ] Type a list of integers seperated by commas for your collection
                  (at least 5 integers)
            ");
            string input = Console.ReadLine();
            List<int> userCollection = new List<int>();
            try
            {
                userCollection = parseCollection(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[!] {ex.Message} [!]");
                Console.WriteLine(">> Invalid Input: Please enter only integers seperated by commas.");
                return GetUserCollection();
            }
            return userCollection;
        }

        private static List<int> parseCollection(string input)
        {
            List<int> userList = input.Split(',')
                           .Select(part => part.Trim())
                           .Where(part => !string.IsNullOrEmpty(part))
                           .Select(part =>
                           {
                               bool success = int.TryParse(part, out int parsedNumber);
                               if (!success)
                                   throw new ArgumentException(
                                   $"'{part}' is not a valid integer.");
                               return parsedNumber;
                           })
                           .ToList();
            if (userList.Count < 5)
            {
                throw new ArgumentException("[!] Collection provided is less than 5 numbers... [!]");
            }
            return userList;

        }



        public static void PrintHeader(List<int> aList, int start, int stop)
        {
            for (int i = start; i < stop; ++i)
                Console.Write("[{0,2}]", i);
            Console.WriteLine();
        }

        public static void Print2(List<int> aList, int start, int stop)
        {
            for (int i = start; i < stop; ++i)
            {
                if (i == start || i == (start - 1 + stop) / 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i == (stop - 1))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}<==", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                    Console.Write("{0,4}", aList[i]);
            }

            Console.WriteLine();
        }
        public static void Print3(List<int> aList, int start, int stop, int pivotPos)
        {
            for (int i = start; i < stop; ++i)
            {
                if (i < pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i == pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i > pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            Console.WriteLine();
        }

        /*
         * Black 0, DarkBlue 1, DarkGreen 2, DarkCyan 3, DarkRed 4, DarkMagenta 5, DarkYellow 6, Gray 7, DarkGray 8, 
         * Blue 9, Green 10, Cyan 11, Red 12, Magenta 13, Yellow 14, White 15  	
         */
        public static void printEvery(List<int> aList, int start, int stop, int ith)
        {
            for (int i = start; i < stop; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                int colorValue = 10 + (i % ith);
                if (colorValue == 9 || colorValue == 4 || colorValue == 5)
                    Console.ForegroundColor = ConsoleColor.White;

                Console.BackgroundColor = (ConsoleColor)colorValue;
                Console.Write("{0,4}", aList[i]);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.WriteLine();
        }
        public static void Print(List<int> aList, int start = 0, int end = -1)
        {
            if (end == -1)
                end = aList.Count;

            for (int i = start; i < end; i++)
                Console.Write("{0,4}", aList[i]);
            Console.WriteLine();
        }
        public static void printOne(List<int> aList, int pos, int start = 0, int end = -1)
        {
            if (end == -1)
                end = aList.Count;

            for (int i = start; i < end; i++)
            {
                if (pos != i)
                    Console.Write("{0,4}", aList[i]);
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            Console.WriteLine();
        }

        public static void enterToContinue()
        {
            Console.WriteLine("\n[ Press ENTER to Continue... ]\n");
            Console.ReadLine();
        }





    }
}
