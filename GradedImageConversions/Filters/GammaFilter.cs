using System;

namespace GradedImageConversions.Filters
{
    class GammaFilter : AbstractCorrectionFIlter
    {
        protected override double operation(double r, double y)
        {
            return Math.Pow(r, y);
        }

        public override string getSecondParamName()
        {
            return "Y";
        }
    }
}
