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
           
        Console.WriteLine("test works"); 
        Console.Read(); //keeps console window open
        }
   
    }
}