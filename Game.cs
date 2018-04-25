using System;

namespace PacmanProject
{
    public static class Game
    {
        public static ICreature[,] Map;
        public static int MapWidth => Map.GetLength(0);
        public static int MapHeight => Map.GetLength(1);
        public static bool IsOver;
    }
}
