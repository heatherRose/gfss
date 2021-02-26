using System;

namespace GFSS_One
{
    public class ECC_OhmCalculator : ICalculateOhmValues
    {
        private readonly IColorCodeParser _colorCodeParser;

        public ECC_OhmCalculator(IColorCodeParser colorToNumberParser)
        {
            _colorCodeParser = colorToNumberParser;
        }


        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor)
        {
            var dig1 = _colorCodeParser.ConvertColorToInt(bandAColor).ToString();
            var dig2 = _colorCodeParser.ConvertColorToInt(bandBColor).ToString();
            var pow10 = bandCColor != null ? string.Join('0', new int[_colorCodeParser.ConvertColorToInt(bandCColor)]) : string.Empty;

            var ohmString = String.Format("{0}{1}{2}",dig1, dig2, pow10);
            return int.Parse(ohmString);
        }

        public (int ohm, double tolerance) CalculateOhmValueWithTolerance(string bandAColor, string bandBColor, string bandCColor, string bandDColor = null)
        {
            var dig1 = _colorCodeParser.ConvertColorToInt(bandAColor).ToString();
            var dig2 = _colorCodeParser.ConvertColorToInt(bandBColor).ToString();
            var pow10 = bandCColor != null ? string.Join('0', new int[_colorCodeParser.ConvertColorToInt(bandCColor)]) : string.Empty;

            var ohmString = String.Format("{0}{1}{2}", dig1, dig2, pow10);

            var tolerance = bandDColor != null ? _colorCodeParser.ConvertColorToPercentage(bandDColor) : 20.0;

            return (ohm: int.Parse(ohmString), tolerance);
        }
    }
}
