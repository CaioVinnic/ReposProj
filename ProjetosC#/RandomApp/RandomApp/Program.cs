using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomApp
{
    class Program
    {
        private static string[] Players = new string[] { "Vinnic", "Drisdian", "Rene", "Dadico", "Gizao",
                                                        "Mackenzie", "Perna", "Jubira", "Grande", "Pae",
                                                        "Farkas"};
        private static string[] Teams = new string[] { "PSG","Borussia","Man. City","Juventus",
                                                       "Real Madrid","Bayern","Barcelona","Chelsea",
                                                       "Liverpool","Napoli","Atl. Madrid","Arsenal",
                                                       "Internazionale","Ajax","Tottenham","Man. Untd."};

        //private static string[] Bots = new string[] { "Internazionale", "Milan", "Valencia", "Roma", "Ajax" };

        public static void Main()
        {

            int i = 0;
            string[] shuffle = RandomizeStrings(Teams);
            foreach (string s in shuffle)
            {
                Console.Write(Players[i++]);
                Console.Write(" : ");
                Console.WriteLine(s);
            }

            //BOTS
            //i = 0;
            //string[] shuffle2 = RandomizeStrings(Bots);
            //foreach (string s in shuffle2)
            //{
            //    i++;
            //    Console.Write("BOT{0}",i);
            //    Console.Write(" : ");
            //    Console.WriteLine(s);
            //}


            Console.ReadLine();
        }

        static string[] RandomizeStrings(string[] arr)
        {
            List<KeyValuePair<int, string>> list =
                new List<KeyValuePair<int, string>>();
            // Add all strings from array.
            // ... Add new random int each time.
            Random random = new Random();
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(random.Next(), s));
            }
            // Sort the list by the random number.
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array.
            string[] result = new string[arr.Length];
            // Copy values to array.
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array.
            return result;
        }

    }
}