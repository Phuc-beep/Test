﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Match
    {
        private int matchID;
        private int tournamentID;
        private int team1ID;
        private int team2ID;
        private DateTime matchDate;
        private string location;
        private int teamWin;
        private string result;

        public Match(int matchID, int tournamentID, int team1ID, int team2ID, DateTime matchDate, string location, int teamWin, string result)
        {
            this.MatchID = matchID;
            this.TournamentID = tournamentID;
            this.Team1ID = team1ID;
            this.Team2ID = team2ID;
            this.MatchDate = matchDate;
            this.Location = location;
            this.TeamWin = teamWin;
            this.Result = result;
        }

        public int MatchID { get => matchID; set => matchID = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public int Team1ID { get => team1ID; set => team1ID = value; }
        public int Team2ID { get => team2ID; set => team2ID = value; }
        public DateTime MatchDate { get => matchDate; set => matchDate = value; }
        public string Location { get => location; set => location = value; }
        public int TeamWin { get => teamWin; set => teamWin = value; }
        public string Result { get => result; set => result = value; }
    }
}
