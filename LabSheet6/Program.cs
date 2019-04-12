using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            //Game g1 =
            //    new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));


            //Game g10 = new Game() { ReleaseDate = new DateTime(1980, 06, 30) };


            //Game g11 = new Game("Ludo", 15m);


            //Game g2 =
            //    new Game("Scrabble", 9.99m, new DateTime(1980, 06, 30));

            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 3, 15), "U");

            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1995, 11, 17), "7");

            FieldGame fg = new FieldGame();

            //DisplayGame(g1);
            //DisplayGame(g2);
            DisplayGame(cg1);
            DisplayGame(cg2);

            DisplayGame(fg);

        }

        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
