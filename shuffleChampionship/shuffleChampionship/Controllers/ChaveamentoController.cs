using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shuffleChampionship.Models;
using System;

namespace shuffleChampionship.Controllers
{
    public class ChaveamentoController : Controller
    {
        public IActionResult Oitavas()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        public IActionResult Quartas()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        public IActionResult Grupos32()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        public IActionResult Grupos16()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        public IActionResult Grupos8()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        public IActionResult Campeonato()
        {
            int i = 0;
            ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
            Jogadores jog = new Jogadores();
            ParticipantesModel model = new ParticipantesModel();

            string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);
            foreach (string s in shuffleTeam)
            {
                jog.PlayerTeam[i] = model.Players[i] + " (" + s + ")";
                i++;
            }

            model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

            return View(model);
        }

        //campeonato com mais times do que participantes:
        //public IActionResult Campeonato()
        //{
        //    ShuffleTeamPlayers rdm = new ShuffleTeamPlayers();
        //    Jogadores jog = new Jogadores();
        //    ParticipantesModel model = new ParticipantesModel();

        //    string[] shuffleTeam = rdm.RandomizeStrings(model.Teams);

        //    for (int i = 0; i < 5; i++)
        //    {
        //        jog.PlayerTeam[i] = model.Players[i] + " (" + shuffleTeam[i] + ")";
        //    }

        //    model.PlayersTeams = rdm.RandomizeStrings(jog.PlayerTeam);

        //    return View(model);
        //}
    }
}
