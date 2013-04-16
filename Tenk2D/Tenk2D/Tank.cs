using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tenk2D
{
    class Tank: GameObj
    {
        private Image image = null;
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

        public Image Img
        {
            get { return image; }
            set { image = value; }
        }
        
        public Tank(Image img,Int32 x,Int32 y,String name): base(x,y,name)
        {
            this.image = img;                       
        }//end const


    }//end class

}//end namespace
