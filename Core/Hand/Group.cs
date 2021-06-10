using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class Group
    {
        public MahjongTile FirstTile { get; }

        public List<MahjongTile> Tiles { get; }

        public Group(IReadOnlyList<MahjongTile> tiles)
        {
            Tiles = tiles.ToList();
            FirstTile = Tiles.First();
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

        protected bool Equals(Group other)
        {
            return Tiles.SequenceEqual(other.Tiles);
        }

        public override int GetHashCode()
        {
            return Tiles.GetHashCode();
        }
    }
}
