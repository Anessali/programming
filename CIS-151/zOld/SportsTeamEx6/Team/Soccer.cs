using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeams
{
    public class Soccer : Team, IBudget
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

        public double TeamFunding()
        {
            double funding = 1000000;
            double cleaning = 1000;
            double total = funding - cleaning;
            return total;
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
