using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tenk2D
{
    class Wall: GameObj
    {

        private Image img = null;

        public Image Img
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

        public Wall(Image img, Int32 x, Int32 y, String name): base(x,y,name)
        {
            this.img = img;            
        }//end const
    }//end class

}//end namespace
