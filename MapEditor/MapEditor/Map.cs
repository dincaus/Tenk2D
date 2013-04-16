using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace MapEditor
{
    [Serializable()]
    class Map
    {
        ArrayList matrixTiles = null;        

        public ArrayList MatrixTiles
        {
            get { return matrixTiles; }
            set { matrixTiles = value; }
        }

        public Map(ArrayList matrixTiles=null)
        {
            this.matrixTiles = matrixTiles;
        }//end const

        public Map(Stream strm)
        {
            BinaryFormatter bf = new BinaryFormatter();            
            Map mp = (Map)bf.Deserialize(strm);
            this.matrixTiles = mp.matrixTiles;
        }//end const

        public void drawMap(Graphics gDraw)
        {
            for (int i = 0; i < matrixTiles.Count; i++)
            {
                GameObj t = (GameObj)matrixTiles[i];

                if (t is Wall)
                {
                   gDraw.DrawImage(((Wall)matrixTiles[i]).Img, new Point(((Wall)matrixTiles[i]).getX, ((Wall)matrixTiles[i]).getY));
                }
                else if (t is Tank)
                {
                    gDraw.DrawImage(((Tank)matrixTiles[i]).Img, new Point(((Tank)matrixTiles[i]).getX, ((Tank)matrixTiles[i]).getY));
                }
            }//end for i        
        }//end method       
                
    }//end class

}//end namespace
