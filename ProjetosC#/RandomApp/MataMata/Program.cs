using System;
using System.Collections.Generic;
using System.Linq;

namespace MataMata
{
    class Program
    {
        private static string[] Players = new string[] { "Vinnic", "Drisdian", "Rene", "Dadico", "Gizao",
                                                        "Mackenzie", "Perna", "Jubira", "Grande", "Pae",
                                                        "Farkas","BOT1","BOT2","BOT3","BOT4","BOT5",};


        public static void Main()
        {

            int i = 0;
            string[] shuffle = RandomizeStrings(Players);

            Console.WriteLine("CLASSIFICACAO:");
            foreach (string s in shuffle)
            {
                i++;
                Console.Write("{0} - ", i);
                Console.WriteLine(s);
            }

            Console.WriteLine();

            Console.WriteLine("OITAVAS:");
            Console.WriteLine("{0} vs {1}", shuffle[0], shuffle[15]);
            Console.WriteLine("{0} vs {1}", shuffle[1], shuffle[14]);
            Console.WriteLine("{0} vs {1}", shuffle[2], shuffle[13]);
            Console.WriteLine("{0} vs {1}", shuffle[3], shuffle[12]);
            Console.WriteLine("{0} vs {1}", shuffle[4], shuffle[11]);
            Console.WriteLine("{0} vs {1}", shuffle[5], shuffle[10]);
            Console.WriteLine("{0} vs {1}", shuffle[6], shuffle[9]);
            Console.WriteLine("{0} vs {1}", shuffle[7], shuffle[8]);

            Console.ReadLine();                       

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
}