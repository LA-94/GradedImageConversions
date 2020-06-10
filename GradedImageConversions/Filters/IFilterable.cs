using System.Drawing;

namespace GradedImageConversions.Filters
{
    interface IFilterable
    {
        Bitmap convertImage(Image image, string a, string b, bool isDark);
        string getFirstParamName();
        string getSecondParamName();
        bool hasDarknessParam();
    }
}
