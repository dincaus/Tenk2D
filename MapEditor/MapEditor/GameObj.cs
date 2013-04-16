using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor
{
    abstract class GameObj
    {
        private Int32 x;

        virtual public Int32 getX
        {
            get { return x; }
            set { x = value; }
        }
        private Int32 y;

        virtual public Int32 getY
        {
            get { return y; }
            set { y = value; }
        }
        private String name;

        virtual public String getName
        {
            get { return name; }
            set { name = value; }
        }

        public GameObj(Int32 x, Int32 y, String name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }//end const


    }//end class
}
