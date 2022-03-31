using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCampeonato
{
    class MataMata
    {
        public void GerarOitavas(string[] arr)
        {
            #region oitavas
            Console.WriteLine("================= OITAVAS =================");
            Console.WriteLine();

            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shuffle2 = rdm.RandomizeStrings(arr);

            for (int x = 0; x < 16; x = x + 2)
            {
                Console.WriteLine(shuffle2[x] + "   vs   " + shuffle2[x + 1]);
            }
            Console.ReadLine();
            #endregion
        }

        public void GerarQuartas(string[] arr)
        {
            #region quartas
            Console.WriteLine("================= QUARTAS =================");
            Console.WriteLine();

            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shuffle2 = rdm.RandomizeStrings(arr);

            for (int x = 0; x < 8; x = x + 2)
            {
                Console.WriteLine(shuffle2[x] + "   vs   " + shuffle2[x + 1]);
            }
            Console.ReadLine();
            #endregion
        }

        
    }
}
