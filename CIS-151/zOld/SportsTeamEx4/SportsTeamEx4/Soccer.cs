using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeams
{
    class Soccer : Team
    {
        private string ballColor;
        private int numOfPlayers;

        public Soccer(string name, string coach, string team,
            string color, int players)
            : base(name, coach, team)
        {
            ballColor = color;
            numOfPlayers = players;
        }

        public override int NumOfPlayers()
        {
            return numOfPlayers;
        }
         
        //string override
        public override string ToString()
        {
            return "The " + base.SportName +
                " team, " + base.TeamName +
                ", is coached by " +
                base.CoachName + "." +
                "\nBall Color: " + ballColor +
                "\nNumber of players: " + numOfPlayers
                ;
        }
    }
}
