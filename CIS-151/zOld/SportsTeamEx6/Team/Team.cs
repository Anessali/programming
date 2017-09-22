using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeams
{
    public abstract class Team //abstract added so class can't be instantiated
    {
        #region class variables
        private string sportName;
        private string coachName;
        private string teamName;
        #endregion
        #region getters and setters
        public string SportName
        {
            get
            {
                return sportName;
            }

            set
            {
                sportName = value;
            }
        }

        public string CoachName
        {
            get
            {
                return coachName;
            }

            set
            {
                coachName = value;
            }
        }

        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }
        #endregion

        public Team(string name, string coach, string team)
        {
            sportName = name;
            coachName = coach;
            teamName = team;
        }

        public virtual int NumOfPlayers()
        {
            return 21;
        }

        public override string ToString()
        {
            return "The " + sportName + 
                " team, " +  teamName + 
                ", is coached by " +
                coachName + "."
                ;
        }
    }
}
