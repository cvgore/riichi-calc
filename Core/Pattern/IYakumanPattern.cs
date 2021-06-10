﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    interface IYakumanPattern
    {
        string Name();

        /// <summary>
        /// Tests if set matches pattern.
        /// </summary>
        bool Matches(TableContext ctx, ParsedHand hand);
        /// <summary>
        /// Must be greater than 0, returns points given to player, when pattern matches and hand is not opened
        /// </summary>
        uint BigPoints();
        /// <summary>
        /// Set to zero if pattern is not permitted while hand has been opened.
        /// Set to null, if equals to points given while hand is closed
        /// </summary>
        uint BigPointsOpenHanded();
    }
}