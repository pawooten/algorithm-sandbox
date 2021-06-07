using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSandbox
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// Individual members of a struct can have the readonly modifier applied
        /// </summary>
        public readonly double Distance => Math.Sqrt( X * X + Y * Y );

        /// <summary>
        /// Compiler warning if ToString() references Distance and Distance isn't also readonly
        /// </summary>
        /// <returns></returns>
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
