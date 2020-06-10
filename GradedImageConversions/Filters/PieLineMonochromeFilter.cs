using System.Drawing;

namespace GradedImageConversions.Filters
{
    class PieLineMonochromeFilter : AbstractPieLineFilter
    {
        private static readonly Color WHITE_COLOR = Color.FromArgb(WHITE_VAL, WHITE_VAL, WHITE_VAL, WHITE_VAL);

        protected override Color operation(Color pixel, double a, double b, bool isDark)
        {
            float gray = getGrayVal(pixel);
            if ((gray < a || gray > b))
            {
               return isDark ? WHITE_COLOR : DARK_COLOR;
            }
            else
            {
                return isDark ? DARK_COLOR : WHITE_COLOR;
            }
        }
    }
}  