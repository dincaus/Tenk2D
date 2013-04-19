using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MapEditor
{
    class TransformBmp
    {
        //radi testirano donekle, rotira oko centra
        public static Bitmap rotateBitmap(Bitmap source, float angle)
        {
            var newBmp = new Bitmap(source.Width, source.Height);
            var graphics = Graphics.FromImage((Image)newBmp);

            graphics.TranslateTransform((float)source.Width / 2, (float)source.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)source.Width / 2, -(float)source.Height / 2);
            graphics.DrawImage((Image)source, new Point(0, 0));
            return newBmp;
        }//end method

        //rotira oko (cx, cy) tacke
        public static Bitmap rotateBitmap(Bitmap source, float angle, int cx, int cy)
        {
            var newBmp = new Bitmap(source.Width, source.Height);
            var graphics = Graphics.FromImage((Image)newBmp);

            graphics.TranslateTransform((float)cx / 2, (float)cy / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)cx / 2, -(float)cy / 2);
            graphics.DrawImage((Image)source, new Point(0, 0));
            return newBmp;
        }//end method

    }//end class

}//end namespace
