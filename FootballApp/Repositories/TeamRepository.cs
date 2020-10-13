using System;
using System.Collections.Generic;
using FootballApp.Models;

namespace FootballApp.Repositories
{
    public class TeamRepository
    {
        List<Team> _teams;
        public TeamRepository()
        {
            Team team1 = new Team();
            team1.name = "Smith";
            team1.colour = "Orange";
            Team team2 = new Team();
            team2.name = "Baker";
            team2.colour = "White";
            _teams = new List<Team> { team1, team2 };
        }

        public Team[] GetAll()
        {
            return _teams.ToArray();
        }
    }
}
