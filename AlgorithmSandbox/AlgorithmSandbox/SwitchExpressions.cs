using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSandbox
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }
    public class RGBColor
    {
        public long R { get; set; }
        public long G { get; set; }
        public long B { get; set; }

        public RGBColor(long r, long g, long b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    public class SwitchExpressions
    {
        /// <summary>
        /// Switch expression rather than the swtich statement. Note expression prior to switch keyword, label expressions for each case
        /// and the discard operator for the default case.
        /// </summary>
        /// <param name="colorBand"></param>
        /// <returns></returns>
        public static RGBColor FromRainbow( Rainbow colorBand ) =>
            colorBand switch
            {
                Rainbow.Red => new RGBColor( 0xFF, 0x00, 0x00 ),
                Rainbow.Orange => new RGBColor( 0xFF, 0x7F, 0x00 ),
                Rainbow.Yellow => new RGBColor( 0xFF, 0xFF, 0x00 ),
                Rainbow.Green => new RGBColor( 0x00, 0xFF, 0x00 ),
                Rainbow.Blue => new RGBColor( 0x00, 0x00, 0xFF ),
                Rainbow.Indigo => new RGBColor( 0x4B, 0x00, 0x82 ),
                Rainbow.Violet => new RGBColor( 0x94, 0x00, 0xD3 ),
                _ => throw new ArgumentException( message: "invalid enum value", paramName: nameof( colorBand ) ),
            };
    }
}
