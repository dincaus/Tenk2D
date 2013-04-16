using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MapEditor
{
    class Tank: GameObj
    {
        private Bitmap image = null;
        private int speed = 0;
        private int damage = 100;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Bitmap Img
        {
            get { return image; }
            set { image = value; }
        }

        private int cordXInMatrix = -1;

        public int CordXInMatrix
        {
            get { return cordXInMatrix; }
            set { cordXInMatrix = value; }
        }
        private int cordYInMatrix = -1;

        public int CordYInMatrix
        {
            get { return cordYInMatrix; }
            set { cordYInMatrix = value; }
        }

        
        public Tank(Bitmap img,Int32 x,Int32 y,String name): base(x,y,name)
        {
            this.image = img;                       
        }//end const

        public void resizeBitmapToCellSize(int cellSize)
        {
            Bitmap bmp = new Bitmap(this.Img);
            Graphics.FromImage((Image)bmp).DrawImage(this.Img, 0, 0, cellSize, cellSize);
        }//end method

    }//end class

}//end namespace
