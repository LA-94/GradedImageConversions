using System.Drawing;

namespace GradedImageConversions.Filters
{
    abstract class AbstractPieLineFilter : AbstractFilter
    {
        protected const int COUNT_COLOR = 3;
        protected static readonly Color DARK_COLOR = Color.FromArgb(WHITE_VAL, DARK_VAL, DARK_VAL, DARK_VAL);

        protected abstract Color operation(Color pixel, double a, double b, bool isDark);

        protected override Color transformPixel(Color pixel, double a, double b, bool isDark)
        {
            return correction(pixel, a, b, isDark);
        }

        private Color correction(Color pixel, double a, double b, bool isDark)
        {
            return operation(pixel, a, b, isDark);
        }

        protected float getGrayVal(Color pixel)
        {
            return (float)(pixel.R + pixel.G + pixel.B) / COUNT_COLOR;
        }

        public override string getFirstParamName()
        {
            return "A";
        }

        public override string getSecondParamName()
        {
            return "B";
        }

        public override bool hasDarknessParam()
        {
            return true;
        }
    }
}
