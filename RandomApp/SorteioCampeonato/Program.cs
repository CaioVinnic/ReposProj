namespace SorteioCampeonato
{
    using System;
    using System.Threading;

    class Program
    {
        private static string[] Players = new string[] { "Vinnic", "Drisdian", "Rene", "Dadico", "Gizao",
                                                        "Mackenzie", "Perna", "Jubira", "Grande", "Português",
                                                        "Claytaum","Witsel","Brunim","8-bit","Prosdocimi",
                                                        "Farkas"};
        
        private static string[] Teams = new string[] { "PSG","Borussia","Man. City","Juventus",
                                                       "Real Madrid","Bayern","Barcelona","Chelsea",
                                                       "Liverpool","Napoli","Atl. Madrid","Arsenal",
                                                       "Internazionale","Ajax","Tottenham","Man. Untd."};

        public static void Main()
        {
            int i = 0;
            int n = Players.Length;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores(n);
            FaseGrupos grupos = new FaseGrupos();
            MataMata mataMata = new MataMata();

            string[] shuffleTeam = rdm.RandomizeStrings(Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = Players[i] + " (" + s + ")";
                i++;
            }

            Console.WriteLine("=== Qual o tipo de torneio? ===");
            Console.WriteLine("1 - Fase de Grupos (32 times)");
            Console.WriteLine("2 - Fase de Grupos (16 times)");
            Console.WriteLine("3 - Fase de Grupos (8 times)");
            Console.WriteLine("4 - Oitavas de Final (16 times)");
            Console.WriteLine("5 - Quartas de Final (8 times)");
            Console.WriteLine("6 - Gerar confronto 1 vs 1");

            int op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                case 1:
                    grupos.GerarGrupos32(jog.PlayerTeam);
                    break;
                case 2:
                    grupos.GerarGrupos16(jog.PlayerTeam);
                    break;
                case 3:
                    grupos.GerarGrupos8(jog.PlayerTeam);
                    break;
                case 4:
                    mataMata.GerarOitavas(jog.PlayerTeam);
                    break;
                case 5:
                    mataMata.GerarQuartas(jog.PlayerTeam);
                    break;
                case 6:
                    Gerar1vs1(Teams);
                    break;
            }
        }
        public static void Gerar1vs1(string[] arr)
        {
            #region 1 vs 1
            Console.WriteLine("================= 1 vs 1 =================");
            Console.WriteLine();

            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();

            string[] shuffle = rdm.RandomizeStrings(arr);

            Random rd = new Random();

            for (int x = 0; x < 25; x++)
            {
                int i = rd.Next(0,15);
                Console.Clear();
                Console.Write(shuffle[i] + "   vs   " + shuffle[i + 1]);
                Thread.Sleep(75);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
