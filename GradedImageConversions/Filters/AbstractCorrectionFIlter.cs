using System.Drawing;

namespace GradedImageConversions.Filters
{
    abstract class AbstractCorrectionFIlter : AbstractFilter
    {
        protected override Color transformPixel(Color pixel, double c, double y, bool isDark)
        {
            return Color.FromArgb(pixel.A, correction(pixel.R, c, y), correction(pixel.G, c, y), correction(pixel.B, c, y));
        }

        protected abstract double operation(double r, double y);

        private int correction(double r, double c, double y)
        {
            int from = 0;
            int to = 1;
            r = r / WHITE_VAL;
            double res = c * operation(r, y);
            res = res > to ? to : res < from ? from : res;
            return (int)(res * WHITE_VAL);
        }

        public override string getFirstParamName()
        {
            return "C";
        }
    }
}
