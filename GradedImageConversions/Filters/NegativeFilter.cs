using System.Drawing;

namespace GradedImageConversions.Filters
{
    class NegativeFilter : AbstractFilter
    {
        private int negative(int r)
        {
            return WHITE_VAL - r;
        }        

        protected override Color transformPixel(Color pixel, double a, double b, bool isDark)
        {
            return Color.FromArgb(pixel.A, negative(pixel.R), negative(pixel.G), negative(pixel.B));
        }
    }
}
