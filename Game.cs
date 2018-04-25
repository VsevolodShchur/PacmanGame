using System;

namespace PacmanProject
{
    public class Game
    {
        public static Cell[,] Map;
        public static int MapWidth => Map.GetLength(0);
        public static int MapHeight => Map.GetLength(1);
        public static bool IsOver;
    }

    public enum Cell
    {
        wall,
        empty
    }
}
