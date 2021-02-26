using System;
using System.Collections.Generic;
using System.Text;

namespace GFSS_One
{
    public class ECC_ColorCodeParser : IColorCodeParser
    {
        private static Dictionary<string, int> dictValuesForColors = new Dictionary<string, int>()
        {
            {"black", 0},
            {"brown", 1 },
            {"red", 2 },
            {"orange", 3 },
            {"yellow", 4 },
            {"green", 5 },
            {"blue", 6 },
            {"violet", 7 },
            {"gray", 8 },
            {"white", 9 }
        };

        private static Dictionary<string, double> dictPercentagesForColors = new Dictionary<string, double>()
        {
            {"silver", 10.00},
            {"gold", 5.00},
            {"brown", 1.00 },
            {"red", 2.00 },
            {"orange", 0.05 },
            {"yellow", 0.02 },
            {"green", 0.50 },
            {"blue", 0.25 },
            {"violet", 0.10 },
            {"grey", 0.01 }
        };

        public ECC_ColorCodeParser()
        {

        }

        public int ConvertColorToInt(string color)
        {
            if (dictValuesForColors.TryGetValue(color.ToLowerInvariant(), out int number))
            {
                return number;
            }

            throw new Exception($"String {color} does not correspond to a color used in EEC");
        }

        public double ConvertColorToPercentage(string color)
        {
            if (dictPercentagesForColors.TryGetValue(color.ToLowerInvariant(), out double percent))
            {
                return percent;
            }

            throw new Exception($"String {color} does not correspond to a tolerance color used in EEC");
        }
    }
}
