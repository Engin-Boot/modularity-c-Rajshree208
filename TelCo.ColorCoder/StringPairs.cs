using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
 partial class Program
    {
        /// <summary>
        /// Gives a big string containing the pair number corresponding to their major and minor colors
        /// </summary>
        /// <returns></returns>

        private static string showAllPairsInString()
        {
            Console.WriteLine("\n-----REFERENCE MANUAL-----\n");
            string refManual = "";
            int noOfColorPairs = colorMapMinor.Length * colorMapMajor.Length;
            for (int pairNo = 1; pairNo <= noOfColorPairs; pairNo++)
            {
                ColorPair majorMinorColorPair = GetColorFromPairNumber(pairNo);
                refManual += "(" + pairNo.ToString() + "->" + majorMinorColorPair.ToString() + ")" + "\n";
            }
            return refManual;
        }
    }
}
