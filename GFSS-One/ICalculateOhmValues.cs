using System;
using System.Collections.Generic;
using System.Text;

namespace GFSS_One
{
    public interface ICalculateOhmValues
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal muliplier band.</param>
        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor);

        /// <summary>
        /// Calculates the Ohm value and the Tolerance (as percentage) of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal muliplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band (optional).</param>
        (int ohm, double tolerance) CalculateOhmValueWithTolerance(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }
}
