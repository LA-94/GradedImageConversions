using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedImageConversions.Filters
{
    class LogFilter : AbstractCorrectionFIlter
    {
        protected override double operation(double r, double y)
        {
            return Math.Log(1 + r, 2);
        }
    }
}
