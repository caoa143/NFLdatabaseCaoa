using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootBallOPP
{
    class Players : Team
    {
        public string PlayerName { get; set; }
        public string PlayerNum { get; set; }

        public string Position { get; set; }
        public string TeamOf { get; set; }

        

        public string GetLocation ()
        {
            return TeamLoc;
            
        }

        public string getTeam()
        {
            return TeamOf = TeamName;
        }

        public void SetPos(string positionPlay)
        {
            Position = positionPlay;
        }

        public void ReturnInfo(string input)
        {
            Console.WriteLine(PlayerName+" "+TeamOf+" "+PlayerNum+" "+Position);
        }

       
    }

  
}


//public string Name { get; set; }
//public Point Location { get; set; }

//public void SetName(string thisname)
//{
//    Name = thisname;
//}

//public string GetName()
//{
//    return Name;
//}

//public void SetLocation(Point thisP)
//{
//    Location = thisP;
//}