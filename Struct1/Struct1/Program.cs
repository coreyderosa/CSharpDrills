using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    public struct HockeyPlayer
    {
        public string fullname;
        public int number;
        public string team;
        public void ClearPlayer() //functions can be used from the struct
        {
            fullname = "";
            number = 0;
            team = "";
        }
    }

    public class NHL
    {
        static void Main(string[] args)
        {
            HockeyPlayer player1 = new HockeyPlayer();
            player1.fullname = "Matt Duchene";
            player1.number = 9;
            player1.team = "Colorado Avalanche";
            player1.ClearPlayer();
            Console.WriteLine(player1.fullname + " is number " + player1.number + " and plays for the " + player1.team);

            HockeyPlayer player2 = new HockeyPlayer();
            player2.fullname = "Tyson Barrie";
            player2.number = 4;
            player2.team = "Colorado Avalanche";
            Console.WriteLine(player2.fullname + " is number " + player2.number + " and plays for the " + player2.team);
            Console.Read();
        }

    }
}
