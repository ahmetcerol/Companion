using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace YazılımYapımıWfaUI.Concrete
{
   public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        //COLOR CODES İN HTML FORMAT
        public static List<string> ColorList = new List<string>() { "#2f4f4f",
                                                                    "#8b4513",
                                                                    "#483d8b",
                                                                    "#473c8b",
                                                                    "#00008b",
                                                                    "#191970",
                                                                    "#087EB0",
                                                                    "#1b8bb4",
                                                                    "#53868b",
                                                                    "#00868b",
                                                                    "#8b3a3a",
                                                                    "#b22222",
                                                                    "#8b1a1a",
                                                                    "#a40000",
                                                                    "#800000",
                                                                    "#008080"};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //Fades the color if the value is less than 0.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //Brightens the color if the value is greater than 0.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

