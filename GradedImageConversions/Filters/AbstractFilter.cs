using System.Drawing;


namespace GradedImageConversions.Filters
{
    abstract class AbstractFilter : IFilterable
    {
        protected const int WHITE_VAL = 255;
        protected const int DARK_VAL = 0;
        protected const int STUB = 0;
        private delegate Color Operation(Color pixel);


        protected abstract Color transformPixel(Color pixel, double a, double b, bool isDark);



        public Bitmap convertImage(Image image, string a, string b, bool isDark)
        {
            Operation operation = pixel => transformPixel(pixel, parseToDouble(a), parseToDouble(b), isDark);
            return transformImage(image, operation);
        }


        private Bitmap transformImage(Image image, Operation operation)
        {
            Bitmap input = new Bitmap(image);
            Bitmap output = new Bitmap(input.Width, input.Height);

            for (int i = 0; i < input.Width; i++)
            {
                for (int j = 0; j < input.Height; j++)
                {
                    output.SetPixel(i, j, operation(input.GetPixel(i, j)));
                }
            }

            return output;
        }


        public virtual bool hasDarknessParam()
        {
            return false;
        }

        public virtual string getFirstParamName()
        {
            return null;
        }

        public virtual string getSecondParamName()
        {
            return null;
        }

        private double parseToDouble(string value)
        {
            return string.IsNullOrEmpty(value) ? STUB : double.Parse(value);
        }
    }
}
