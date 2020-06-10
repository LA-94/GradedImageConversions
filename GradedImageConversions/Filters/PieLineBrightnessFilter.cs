using System.Drawing;

namespace GradedImageConversions.Filters
{
    class PieLineBrightnessFilter : AbstractPieLineFilter
    {
        protected override Color operation(Color pixel, double a, double b, bool isDark)
        {
            float gray = getGrayVal(pixel);
            if (gray < a || gray > b)
            {
                return isDark ? pixel : DARK_COLOR;
            }
            else
            {
                return isDark ? DARK_COLOR : pixel;
            }
        }
    }
}