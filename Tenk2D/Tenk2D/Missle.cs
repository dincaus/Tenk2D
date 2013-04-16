using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tenk2D
{
    class Missle: GameObj
    {

        private Image img = null;
        private int damage = -1;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }//end

        public Missle(Image img, Int32 x, Int32 y, String name)
            : base(x, y, name)
        {
            this.img = img;
        }//end const

    }//end class

}//end namespace
