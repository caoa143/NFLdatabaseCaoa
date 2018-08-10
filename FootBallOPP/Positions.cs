using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace FootBallOPP
{
    class Positions:Players
    {
        public string PositionName { get; set; }
        public string PosCat { get; set; }


        public void GetPlayers(string Position)  //is this right?
        {
            ReturnInfo(Position);
        }

        //public string getPos()
        //{
        //    return ;
        //}


    }
}
