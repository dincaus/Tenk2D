using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MapEditor
{
    class Wall: GameObj
    {

        private Bitmap img = null;
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

        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }

        private int damage = 100;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }//end 


        public Wall(Bitmap img, Int32 x, Int32 y, String name)
            : base(x, y, name)
        {
            this.img = img;            
        }//end const

        //Mozda ovaj resize treba pozivati u konstruktoru, ali za sada ga pozivaj zasebno
        public void resizeBitmapToCellSize(int cellSize)
        {
            Bitmap bmp = new Bitmap(this.img);
            Graphics.FromImage((Image)bmp).DrawImage(this.img, 0, 0, cellSize, cellSize);
        }//end method
    }//end class

}//end namespace
