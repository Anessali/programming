using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsTeams;

namespace SportsTeamEx5
{
    public class Test : Team
    {
        public Test(string name, string coach, string team)
               : base(name, coach, team)
        {

        }

        static void Main(string[] args)
        {
            //Subclasses referenced from the team dll
            Hockey hockeyTeam = new Hockey("hockey", "Jack Jacobs", "The Losers", "Finland", 27);
            Soccer newTeam = new Soccer("soccer", "Jordan Gilmore", "The Bowies", "Red", 20);
            //prints subclasses ToString()'s to console
            Console.WriteLine(hockeyTeam);
            Console.WriteLine("$" + hockeyTeam.TeamBudget());
            Console.WriteLine(newTeam);
            Console.WriteLine("$" + newTeam.TeamBudget());
            //prints interface value

            Console.Read(); //keeps console window open
        }
   
    }
}