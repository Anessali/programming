using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsTeams;

namespace SportsTeamEx5
{
    public class Program : Team
    {
        public Program(string name, string coach, string team)
               : base(name, coach, team)
        {

        }

        static void Main(string[] args)
        {
            Hockey hockeyTeam = new Hockey("hockey", "Jack Jacobs", "The Losers", "Finland", 27);
            Console.WriteLine(hockeyTeam); 
            Console.Read(); //keeps console window open
        }
   
    }
}