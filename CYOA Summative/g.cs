using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA_Summative
{
    class g
    {
        //make inventory global
        public static Inv inv = new Inv();
        //make puzzle global
        public static Puzzle1 puzzle1 = new Puzzle1();
        //make keypad global
        public static Keypad keypad = new Keypad();
        //to check if something is in inv
        public static bool corn = false;
        public static bool rock = false;
        public static bool chloroform = false;
        public static bool sword = false;

        //distraction path
        public static string state = "";
        public static bool cornused = false;
        public static bool chloroformused = false;
        public static bool rockused = false;
        //for keypad puzzle
        public static float a1 = 0;
        public static float a2 = 0;
        public static float a3 = 0;
        public static float a4 = 0;
        public static float a5 = 0;

        public static bool accept1 = false;
        public static bool enable = false;

        //save gender
        public static string name = "";
        public static string genderr = "";
    }
}
