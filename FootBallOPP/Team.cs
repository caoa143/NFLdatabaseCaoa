using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootBallOPP
{
    class Team
    {

        public string TeamName { get; set; }
        public string TeamLoc { get; set; }
        //__________________________________________
        public int NumPlayers;
        public void SetNumPlys(int fullRos)
        {
            NumPlayers = 53;
        }

        public int GetNumPlys(int fullRos)
        {
            return NumPlayers;
        }
        //---------------------------------------------

        public void GetPositions(string Position)
        {
            
        }

        public void SetTeam(string tName)
        {
            tName = TeamName;
        }


        public void SetLoc (string tLoc)
        {
            tLoc=TeamLoc;
        }

       // Players thisPlayer = playerList;

    }
}
