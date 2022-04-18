using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SorteioCampeonato
{
    class FaseGrupos
    {
        //int delay = 1500;
        int delay = 0;

        public void GerarGrupos32(string[] arr)
        {
            #region grupos
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shuffle2 = rdm.RandomizeStrings(arr);

            Console.WriteLine("================= GRUPO A =================");
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO B =================");
            for (int x = 4; x < 8; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO C =================");
            for (int x = 8; x < 12; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO D =================");
            for (int x = 12; x < 16; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO E =================");
            for (int x = 16; x < 20; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO F =================");
            for (int x = 20; x < 24; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO G =================");
            for (int x = 24; x < 28; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO H =================");
            for (int x = 28; x < 32; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.ReadLine();
            #endregion
        }

        public void GerarGrupos16(string[] arr)
        {
            #region grupos
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shufflePlayerTeam = rdm.RandomizeStrings(arr);

            Console.WriteLine("================= GRUPO A =================");
            for (int x = 0; x < 4; x++)
            {
                Thread.Sleep(delay);
                Console.WriteLine(shufflePlayerTeam[x]);
            }
            Thread.Sleep(delay);
            Console.WriteLine();

            Console.WriteLine("================= GRUPO B =================");
            for (int x = 4; x < 8; x++)
            {
                Console.WriteLine(shufflePlayerTeam[x]);
                Thread.Sleep(delay);
            }
            Console.WriteLine();

            Console.WriteLine("================= GRUPO C =================");
            for (int x = 8; x < 12; x++)
            {
                Console.WriteLine(shufflePlayerTeam[x]);
                Thread.Sleep(delay);
            }
            Console.WriteLine();

            Console.WriteLine("================= GRUPO D =================");
            for (int x = 12; x < 16; x++)
            {
                Thread.Sleep(delay);
                Console.WriteLine(shufflePlayerTeam[x]);
            }

            Console.WriteLine();
            Console.WriteLine("!!!!!!!!!!!! BOA SORTE À TODOS !!!!!!!!!!!!");
            Console.ReadLine();
            #endregion
        }

        public void GerarGrupos8(string[] arr)
        {
            #region grupos
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shuffle2 = rdm.RandomizeStrings(arr);

            Console.WriteLine("================= GRUPO A =================");
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.WriteLine("================= GRUPO B =================");
            for (int x = 4; x < 8; x++)
            {
                Console.WriteLine(shuffle2[x]);
            }

            Console.ReadLine();
            #endregion
        }
    }
}
