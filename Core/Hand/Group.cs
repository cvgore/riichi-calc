﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    public class Group
    {
        public MahjongTile FirstTile { get; }

        public List<MahjongTile> Tiles { get; }

        public bool Open { get; }

        public Group(IReadOnlyList<MahjongTile> tiles, bool open = false)
        {
            Tiles = tiles.ToList();
            FirstTile = Tiles.First();
            Open = open;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Group)
            {
                return false;
            }

            var grp = (Group) obj;

            return grp.Tiles.SequenceEqual(Tiles);
        }

        public override int GetHashCode()
        {
            return Tiles.GetHashCode();
        }
    }
}