using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor
{

    public struct MatrixPos
    {
        private int cellX, cellY;
        private int cellSize;

        public int CellX
        {
            get
            {
                return cellX;
            }

            set
            {
                cellX = value;
            }
        }//end CellX

        public int CellY
        {
            get
            {
                return cellY;
            }

            set
            {
                cellY = value;
            }
        }//end CellY

        public int Row
        {
            get
            {
                return cellY / cellSize;
            }
        }

        public int Col
        {
            get
            {
                return cellX / cellSize;
            }
        }

        public MatrixPos(int cx, int cy, int cellSize)
        {
            this.cellX = cx;
            this.cellY = cy;
            this.cellSize = cellSize;
        }

        public Point getMatrixPos()
        {
            return new Point(this.cellX / this.cellSize, this.cellY / this.cellSize);
        }//end getMatrixPos


    }//end struct

    public partial class frmMain : Form
    {

        private Map mapContainer = new Map();

        private ArrayList matrixTiles = new ArrayList();
        private ArrayList selectRect = new ArrayList();

        private const int cellSize = 40;

        private bool drawMode = false;
        private bool selectMode = false;

        //GUI
        private bool drawGridMode = false;

        private void changeImageInPicBox(string imgFile)
        {
            if (imgFile == null)
            {
                pictureBox1.Image = null;
            }
            if (!drawMode) return;

            pictureBox1.Image = Image.FromFile(imgFile);
        }//end method

        private enum ObjectsInGame
        { WALL1, WALL2, TENKPLAYER1, TENKPLAYER2, TENKPLAYER3, TENKPLAYER4, TENKENEMY1, TENKENEMY2, TENKENEMY3, TENKENEMY4 };

        private int currentGameObj = -1;

        public int CurrentGameObj
        {
            get { return currentGameObj; }
            set { currentGameObj = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        public void resizeFormEvent(object sender, EventArgs evt)
        {
            lblResolution.Text = pnlMap.Size.Width + " x " + pnlMap.Size.Height;
        }

        private bool isFreeSpot(int x, int y)
        {
            for (int i = 0; i < matrixTiles.Count; i++)
            {
                int tempX, tempY;
                int tempW, tempH;

                if (matrixTiles[i] is Wall)
                {
                    tempX = ((Wall)matrixTiles[i]).CordXInMatrix;
                    tempY = ((Wall)matrixTiles[i]).CordYInMatrix;

                    tempW = ((Wall)matrixTiles[i]).Img.Width;
                    tempH = ((Wall)matrixTiles[i]).Img.Height;

                    if (x <= tempX + tempW && x >= tempX && y <= tempY + tempH && y >= tempY) return false;

                }
                else if (matrixTiles[i] is Tank)
                {
                    tempX = ((Tank)matrixTiles[i]).CordXInMatrix;
                    tempY = ((Tank)matrixTiles[i]).CordYInMatrix;

                    tempW = ((Tank)matrixTiles[i]).Img.Width;
                    tempH = ((Tank)matrixTiles[i]).Img.Height;

                    if (x <= tempX + tempW && x >= tempX && y <= tempY + tempH && y >= tempY) return false;
                }


            }//end for i

            return true;
        }//end method

        private bool isFreeSpot(int x, int y, out int indexObj)
        {
            indexObj = -1;
            for (int i = 0; i < matrixTiles.Count; i++)
            {
                int tempX, tempY;
                int tempW, tempH;

                if (matrixTiles[i] is Wall)
                {
                    tempX = ((Wall)matrixTiles[i]).CordXInMatrix;
                    tempY = ((Wall)matrixTiles[i]).CordYInMatrix;

                    tempW = ((Wall)matrixTiles[i]).Img.Width;
                    tempH = ((Wall)matrixTiles[i]).Img.Height;

                    if (x <= tempX + tempW && x >= tempX && y <= tempY + tempH && y >= tempY)
                    {
                        indexObj = i;
                        return false;
                    }

                }
                else if (matrixTiles[i] is Tank)
                {
                    tempX = ((Tank)matrixTiles[i]).CordXInMatrix;
                    tempY = ((Tank)matrixTiles[i]).CordYInMatrix;

                    tempW = ((Tank)matrixTiles[i]).Img.Width;
                    tempH = ((Tank)matrixTiles[i]).Img.Height;

                    if (x <= tempX + tempW && x >= tempX && y <= tempY + tempH && y >= tempY)
                    {
                        indexObj = i;
                        return false;
                    }
                }//end else if
            }//end for i

            return true;
        }//end method

        private void drawRectangle(Rectangle bound, Graphics gDraw, Color color)
        {
            Pen p = new Pen(color);
            gDraw.DrawRectangle(p, bound);
        }//end method

        private void drawGrid()
        {
            Pen pen = new Pen(Color.Green);
            Graphics g = pnlMap.CreateGraphics();

            for (int x = 0; x <= pnlMap.Width / cellSize; x++)
            {
                for (int y = 0; y <= pnlMap.Height / cellSize; y++)
                {
                    g.DrawLine(pen, x * cellSize, y, x * cellSize, y + pnlMap.Height);
                }//end for y
            }//end for x

            for (int y = 0; y <= pnlMap.Height / cellSize; y++)
            {
                for (int x = 0; x <= pnlMap.Width / cellSize; x++)
                {
                    g.DrawLine(pen, x, y * cellSize, x + pnlMap.Width, y * cellSize);
                }//end for y
            }//end for x
        }//end method


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (drawMode)
            {
                lblDrawMode.Text = "Ukljuceno";
            }
            else
            {
                lblDrawMode.Text = "Iskljuceno";
            }

            if (selectMode)
            {
                lblSelectionMode.Text = "Ukljuceno";
            }
            else
            {
                lblSelectionMode.Text = "Iskljuceno";
            }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            lblResolution.Text = pnlMap.Size.Width + " x " + pnlMap.Size.Height;
            
        }

        protected void renderObject(Graphics g)
        {
            for (int i = 0; i < matrixTiles.Count; i++)
            {
                if (matrixTiles[i] is Wall)
                {
                    g.DrawImage((Image)((Wall)matrixTiles[i]).Img, ((Wall)matrixTiles[i]).CordXInMatrix, ((Wall)matrixTiles[i]).CordYInMatrix);
                }
                else if (matrixTiles[i] is Tank)
                {
                    g.DrawImage((Image)((Tank)matrixTiles[i]).Img, ((Tank)matrixTiles[i]).CordXInMatrix, ((Tank)matrixTiles[i]).CordYInMatrix);
                }
            }//end for i

            if (selectMode)
            {
                for (int i = 0; i < selectRect.Count; i++)
                {
                    g.DrawRectangle(new Pen(Color.Red), (Rectangle)selectRect[i]);
                }//end for i
            }//end if selectMode

        }//end method

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {
            if (drawGridMode)
            {
                drawGrid();
            }//end if
            renderObject(e.Graphics);
        }//end method

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMap_Click(object sender, EventArgs e)
        {

        }//end method

        private void pnlMap_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left && drawMode && currentGameObj != -1)
            {

                Graphics gDraw = pnlMap.CreateGraphics();
                MatrixPos matPos = new MatrixPos(e.X, e.Y, cellSize);

                Wall objWall = null;
                Tank objTank = null;

                switch (currentGameObj)
                {
                    case (int)ObjectsInGame.WALL1:
                        objWall = new Wall(new Bitmap(Image.FromFile(@"img/Walls/Wall1.png")), e.X, e.Y, "WALL1");
                        objWall.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objWall.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objWall.CordXInMatrix = matPos.Col * cellSize;
                        objWall.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.WALL2:
                        objWall = new Wall(new Bitmap(Image.FromFile(@"img/Walls/Wall2.png")), e.X, e.Y, "WALL2");
                        objWall.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objWall.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objWall.CordXInMatrix = matPos.Col * cellSize;
                        objWall.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKPLAYER1:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/player/TenkPlayer1.png")), e.X, e.Y, "TP1");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKPLAYER2:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/player/TenkPlayer2.png")), e.X, e.Y, "TP2");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKPLAYER3:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/player/TenkPlayer3.png")), e.X, e.Y, "TP3");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKPLAYER4:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/player/TenkPlayer4.png")), e.X, e.Y, "TP4");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKENEMY1:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/enemy/TenkEnemy1.png")), e.X, e.Y, "TE1");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKENEMY2:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/enemy/TenkEnemy2.png")), e.X, e.Y, "TE2");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;


                    case (int)ObjectsInGame.TENKENEMY3:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/enemy/TenkEnemy3.png")), e.X, e.Y, "TE3");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;

                    case (int)ObjectsInGame.TENKENEMY4:
                        objTank = new Tank(new Bitmap(Image.FromFile(@"img/enemy/TenkEnemy4.png")), e.X, e.Y, "TE4");
                        objTank.resizeBitmapToCellSize(cellSize);
                        gDraw.DrawImage(objTank.Img, new Point((matPos.Col) * cellSize, (matPos.Row) * cellSize));
                        objTank.CordXInMatrix = matPos.Col * cellSize;
                        objTank.CordYInMatrix = matPos.Row * cellSize;
                        break;
                }//end switch

                if (objWall != null)
                {
                    matrixTiles.Add((Wall)objWall);
                }//end if
                else if (objTank != null)
                {
                    matrixTiles.Add((Tank)objTank);
                }//end else if                
            }//end if
            else if (e.Button == System.Windows.Forms.MouseButtons.Left && selectMode)
            {
                int indexObj = -1;
                Graphics gDraw = pnlMap.CreateGraphics();

                if (!isFreeSpot(e.X, e.Y, out indexObj))
                {
                    Rectangle r = new Rectangle();
                    if (matrixTiles[indexObj] is Wall)
                    {
                        r = new Rectangle( (matrixTiles[indexObj] as Wall).CordXInMatrix,(matrixTiles[indexObj] as Wall).CordYInMatrix,(matrixTiles[indexObj] as Wall).Img.Width,(matrixTiles[indexObj] as Wall).Img.Height);                        
                        
                    }//end if
                    else if (matrixTiles[indexObj] is Tank)
                    {
                        r = new Rectangle((matrixTiles[indexObj] as Tank).CordXInMatrix, (matrixTiles[indexObj] as Tank).CordYInMatrix, (matrixTiles[indexObj] as Tank).Img.Width, (matrixTiles[indexObj] as Tank).Img.Height);                        
                    }//end else if
                    drawRectangle(r, gDraw, Color.Red);
                    
                    selectRect.Add(r);
                }//end if, ako je nasao objekat markiraj ga
            }//end else if

        }//end method

        private void zid1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.WALL1;
            changeImageInPicBox(@"img/Walls/Wall1.png");
        }

        private void zid2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.WALL2;
            changeImageInPicBox(@"img/Walls/Wall2.png");
        }

        private void igrac1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKPLAYER1;
            changeImageInPicBox(@"img/player/TenkPlayer1.png");
        }

        private void igrac2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKPLAYER2;
            changeImageInPicBox(@"img/player/TenkPlayer2.png");
        }

        private void igrac3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKPLAYER3;
            changeImageInPicBox(@"img/player/TenkPlayer3.png");
        }

        private void igrac4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKPLAYER4;
            changeImageInPicBox(@"img/player/TenkPlayer4.png");
        }

        private void neprijatelj1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKENEMY1;
            changeImageInPicBox(@"img/enemy/TenkEnemy1.png");
        }

        private void neprijatelj2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKENEMY2;
            changeImageInPicBox(@"img/enemy/TenkEnemy2.png");
        }

        private void neprijatelj3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKENEMY3;
            changeImageInPicBox(@"img/enemy/TenkEnemy3.png");
        }

        private void neprijatelj4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!drawMode) return;
            currentGameObj = (int)ObjectsInGame.TENKENEMY4;
            changeImageInPicBox(@"img/enemy/TenkEnemy4.png");
        }

        private void pnlMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void crtanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (drawMode)
            {
                drawMode = false;
                crtanjeToolStripMenuItem.Checked = false;
                changeImageInPicBox(null);
                currentGameObj = -1;
                lblDrawMode.Text = "Iskljuceno";
            }
            else
            {
                drawMode = true;
                crtanjeToolStripMenuItem.Checked = true;
                lblDrawMode.Text = "Ukljuceno";
            }
        }

        private void oznacavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectMode)
            {
                oznacavanjeToolStripMenuItem.Checked = selectMode = false;
                lblSelectionMode.Text = "Iskljuceno";
                pnlMap.Invalidate();
            }
            else
            {
                oznacavanjeToolStripMenuItem.Checked = selectMode = true;
                lblSelectionMode.Text = "Ukljuceno";
            }//end else
        }//end method

        private void ispisiSadrzajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void x600ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1052, 700);
            pnlMap.Size = new Size(800, 600);
            groupBox1.Location = new Point(pnlMap.Location.X + pnlMap.Width + 5, pnlMap.Location.Y);
            lblResolution.Text = pnlMap.Size.Width + " x " + pnlMap.Size.Height;
        }

        private void x768ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1276, 860);
            pnlMap.Size = new Size(1024, 768);
            groupBox1.Location = new Point(pnlMap.Location.X + pnlMap.Width + 5, pnlMap.Location.Y);
            lblResolution.Text = pnlMap.Size.Width + " x " + pnlMap.Size.Height;
        }

        private void x480ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(852, 625);
            pnlMap.Size = new Size(600, 480);
            groupBox1.Location = new Point(pnlMap.Location.X + pnlMap.Width + 5, pnlMap.Location.Y);
            lblResolution.Text = pnlMap.Size.Width + " x " + pnlMap.Size.Height;
        }

        private void iscrtajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (drawGridMode)
            {
                drawGridMode = false;
                iscrtajToolStripMenuItem.Checked = false;
            }
            else
            {
                drawGridMode = true;
                iscrtajToolStripMenuItem.Checked = true;
                drawGrid();

            }
            pnlMap.Invalidate();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            
        }//end method

    }//end class
}//end namespace
