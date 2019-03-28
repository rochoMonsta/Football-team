using System;
namespace Homework1
{
    public class Team
    {
        public Team(){}

        Player[] team;

        public Team(int count){ team = new Player[count]; }

        public Player this[int index]
        {
            get
            {
                return team[index];
            }
            set
            {
                team[index] = value;
            }
        }

    }
}
