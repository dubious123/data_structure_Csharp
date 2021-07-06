﻿using System;

namespace multidimensional_Array
{
    class Map
    {
        int[,] tiles =
        {
            {1,1,1,1,1 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {1,1,1,1,1 },


        };
        public void Rneder()
        {
            ConsoleColor DefaultColor = Console.ForegroundColor;
            for (int y=0; y < tiles.GetLength(1); y++)
            {
                for(int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write((char)9312);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = DefaultColor;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Rneder();
        }
    }
}
