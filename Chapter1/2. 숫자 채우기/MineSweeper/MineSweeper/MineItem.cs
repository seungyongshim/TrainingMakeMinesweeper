﻿using System;

namespace MineSweeper
{
    public class MineItem
    {
        public bool IsBomb { get; set; }
        public int NearBombsCount { get; set; }

        public char Value
        {
            get
            {
                throw new NotImplementedException { };
            }
        }
    }
}
