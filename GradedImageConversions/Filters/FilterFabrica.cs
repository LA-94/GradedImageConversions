using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedImageConversions.Filters
{
    enum Filter
    {
        NEGATIVE,
        LOG,
        GAMMA,
        MONOCHROME,
        BRIGHT
    }
    class FilterFabrica
    {
        public static IFilterable createFilter(Filter filter)
        {
            switch (filter){
                case Filter.NEGATIVE:
                    return new NegativeFilter();
                case Filter.LOG:
                    return new LogFilter();
                case Filter.GAMMA:
                    return new GammaFilter();
                case Filter.MONOCHROME:
                    return new PieLineMonochromeFilter();
                case Filter.BRIGHT:
                    return new PieLineBrightnessFilter();
                default:
                    return null;
            }           
        }
    }
}
