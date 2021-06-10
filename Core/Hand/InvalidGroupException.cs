using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Core.Hand
{
    class InvalidGroupException : Exception
    {
        private Group _group;

        public InvalidGroupException(Group @group)
        {
            _group = @group;
        }

        public override string ToString()
        {
            return $"Cannot construct group '{nameof(_group)}' out of tiles: {string.Join(',', _group.Tiles)}";
        }
    }
}