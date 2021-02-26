namespace GFSS_One
{
    public interface IColorCodeParser
    {
        int ConvertColorToInt(string color);

        double ConvertColorToPercentage(string color);
    }
}