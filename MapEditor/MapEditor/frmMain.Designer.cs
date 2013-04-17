namespace MapEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMap = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zid1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zid2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenkoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrac1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrac2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrac3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrac4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprijateljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprijatelj1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprijatelj2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprijatelj3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprijatelj4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crtanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oznacavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezolucijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x768ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iscrtajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelectionMode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDrawMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.Color.Black;
            this.pnlMap.Location = new System.Drawing.Point(12, 38);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(1024, 768);
            this.pnlMap.TabIndex = 0;
            this.pnlMap.Click += new System.EventHandler(this.pnlMap_Click);
            this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);
            this.pnlMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMap_MouseClick);
            this.pnlMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMap_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapToolsToolStripMenuItem,
            this.pogledToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Fajl";
            // 
            // mapToolsToolStripMenuItem
            // 
            this.mapToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zidToolStripMenuItem,
            this.tenkoviToolStripMenuItem,
            this.modoviToolStripMenuItem});
            this.mapToolsToolStripMenuItem.Name = "mapToolsToolStripMenuItem";
            this.mapToolsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.mapToolsToolStripMenuItem.Text = "Alati mape";
            // 
            // zidToolStripMenuItem
            // 
            this.zidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zid1ToolStripMenuItem,
            this.zid2ToolStripMenuItem});
            this.zidToolStripMenuItem.Name = "zidToolStripMenuItem";
            this.zidToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zidToolStripMenuItem.Text = "Zid";
            // 
            // zid1ToolStripMenuItem
            // 
            this.zid1ToolStripMenuItem.Name = "zid1ToolStripMenuItem";
            this.zid1ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.zid1ToolStripMenuItem.Text = "Zid 1";
            this.zid1ToolStripMenuItem.Click += new System.EventHandler(this.zid1ToolStripMenuItem_Click);
            // 
            // zid2ToolStripMenuItem
            // 
            this.zid2ToolStripMenuItem.Name = "zid2ToolStripMenuItem";
            this.zid2ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.zid2ToolStripMenuItem.Text = "Zid 2";
            this.zid2ToolStripMenuItem.Click += new System.EventHandler(this.zid2ToolStripMenuItem_Click);
            // 
            // tenkoviToolStripMenuItem
            // 
            this.tenkoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igracToolStripMenuItem,
            this.neprijateljToolStripMenuItem});
            this.tenkoviToolStripMenuItem.Name = "tenkoviToolStripMenuItem";
            this.tenkoviToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.tenkoviToolStripMenuItem.Text = "Tenkovi";
            // 
            // igracToolStripMenuItem
            // 
            this.igracToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igrac1ToolStripMenuItem,
            this.igrac2ToolStripMenuItem,
            this.igrac3ToolStripMenuItem,
            this.igrac4ToolStripMenuItem});
            this.igracToolStripMenuItem.Name = "igracToolStripMenuItem";
            this.igracToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.igracToolStripMenuItem.Text = "Igrac";
            // 
            // igrac1ToolStripMenuItem
            // 
            this.igrac1ToolStripMenuItem.Name = "igrac1ToolStripMenuItem";
            this.igrac1ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.igrac1ToolStripMenuItem.Text = "Igrac 1";
            this.igrac1ToolStripMenuItem.Click += new System.EventHandler(this.igrac1ToolStripMenuItem_Click);
            // 
            // igrac2ToolStripMenuItem
            // 
            this.igrac2ToolStripMenuItem.Name = "igrac2ToolStripMenuItem";
            this.igrac2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.igrac2ToolStripMenuItem.Text = "Igrac 2";
            this.igrac2ToolStripMenuItem.Click += new System.EventHandler(this.igrac2ToolStripMenuItem_Click);
            // 
            // igrac3ToolStripMenuItem
            // 
            this.igrac3ToolStripMenuItem.Name = "igrac3ToolStripMenuItem";
            this.igrac3ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.igrac3ToolStripMenuItem.Text = "Igrac 3";
            this.igrac3ToolStripMenuItem.Click += new System.EventHandler(this.igrac3ToolStripMenuItem_Click);
            // 
            // igrac4ToolStripMenuItem
            // 
            this.igrac4ToolStripMenuItem.Name = "igrac4ToolStripMenuItem";
            this.igrac4ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.igrac4ToolStripMenuItem.Text = "Igrac 4";
            this.igrac4ToolStripMenuItem.Click += new System.EventHandler(this.igrac4ToolStripMenuItem_Click);
            // 
            // neprijateljToolStripMenuItem
            // 
            this.neprijateljToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neprijatelj1ToolStripMenuItem,
            this.neprijatelj2ToolStripMenuItem,
            this.neprijatelj3ToolStripMenuItem,
            this.neprijatelj4ToolStripMenuItem});
            this.neprijateljToolStripMenuItem.Name = "neprijateljToolStripMenuItem";
            this.neprijateljToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.neprijateljToolStripMenuItem.Text = "Neprijatelj";
            // 
            // neprijatelj1ToolStripMenuItem
            // 
            this.neprijatelj1ToolStripMenuItem.Name = "neprijatelj1ToolStripMenuItem";
            this.neprijatelj1ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.neprijatelj1ToolStripMenuItem.Text = "Neprijatelj 1";
            this.neprijatelj1ToolStripMenuItem.Click += new System.EventHandler(this.neprijatelj1ToolStripMenuItem_Click);
            // 
            // neprijatelj2ToolStripMenuItem
            // 
            this.neprijatelj2ToolStripMenuItem.Name = "neprijatelj2ToolStripMenuItem";
            this.neprijatelj2ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.neprijatelj2ToolStripMenuItem.Text = "Neprijatelj 2";
            this.neprijatelj2ToolStripMenuItem.Click += new System.EventHandler(this.neprijatelj2ToolStripMenuItem_Click);
            // 
            // neprijatelj3ToolStripMenuItem
            // 
            this.neprijatelj3ToolStripMenuItem.Name = "neprijatelj3ToolStripMenuItem";
            this.neprijatelj3ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.neprijatelj3ToolStripMenuItem.Text = "Neprijatelj 3";
            this.neprijatelj3ToolStripMenuItem.Click += new System.EventHandler(this.neprijatelj3ToolStripMenuItem_Click);
            // 
            // neprijatelj4ToolStripMenuItem
            // 
            this.neprijatelj4ToolStripMenuItem.Name = "neprijatelj4ToolStripMenuItem";
            this.neprijatelj4ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.neprijatelj4ToolStripMenuItem.Text = "Neprijatelj 4";
            this.neprijatelj4ToolStripMenuItem.Click += new System.EventHandler(this.neprijatelj4ToolStripMenuItem_Click);
            // 
            // modoviToolStripMenuItem
            // 
            this.modoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crtanjeToolStripMenuItem,
            this.oznacavanjeToolStripMenuItem});
            this.modoviToolStripMenuItem.Name = "modoviToolStripMenuItem";
            this.modoviToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.modoviToolStripMenuItem.Text = "Modovi";
            // 
            // crtanjeToolStripMenuItem
            // 
            this.crtanjeToolStripMenuItem.Name = "crtanjeToolStripMenuItem";
            this.crtanjeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.crtanjeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.crtanjeToolStripMenuItem.Text = "Crtanje";
            this.crtanjeToolStripMenuItem.Click += new System.EventHandler(this.crtanjeToolStripMenuItem_Click);
            // 
            // oznacavanjeToolStripMenuItem
            // 
            this.oznacavanjeToolStripMenuItem.Name = "oznacavanjeToolStripMenuItem";
            this.oznacavanjeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.oznacavanjeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oznacavanjeToolStripMenuItem.Text = "Oznacavanje";
            this.oznacavanjeToolStripMenuItem.Click += new System.EventHandler(this.oznacavanjeToolStripMenuItem_Click);
            // 
            // pogledToolStripMenuItem
            // 
            this.pogledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezolucijaToolStripMenuItem,
            this.gridToolStripMenuItem});
            this.pogledToolStripMenuItem.Name = "pogledToolStripMenuItem";
            this.pogledToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pogledToolStripMenuItem.Text = "Pogled";
            // 
            // rezolucijaToolStripMenuItem
            // 
            this.rezolucijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x480ToolStripMenuItem,
            this.x600ToolStripMenuItem,
            this.x768ToolStripMenuItem});
            this.rezolucijaToolStripMenuItem.Name = "rezolucijaToolStripMenuItem";
            this.rezolucijaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rezolucijaToolStripMenuItem.Text = "Rezolucija";
            // 
            // x480ToolStripMenuItem
            // 
            this.x480ToolStripMenuItem.Name = "x480ToolStripMenuItem";
            this.x480ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.x480ToolStripMenuItem.Text = "600x480";
            this.x480ToolStripMenuItem.Click += new System.EventHandler(this.x480ToolStripMenuItem_Click);
            // 
            // x600ToolStripMenuItem
            // 
            this.x600ToolStripMenuItem.Name = "x600ToolStripMenuItem";
            this.x600ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.x600ToolStripMenuItem.Text = "800x600";
            this.x600ToolStripMenuItem.Click += new System.EventHandler(this.x600ToolStripMenuItem_Click);
            // 
            // x768ToolStripMenuItem
            // 
            this.x768ToolStripMenuItem.Name = "x768ToolStripMenuItem";
            this.x768ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.x768ToolStripMenuItem.Text = "1024x768";
            this.x768ToolStripMenuItem.Click += new System.EventHandler(this.x768ToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iscrtajToolStripMenuItem});
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // iscrtajToolStripMenuItem
            // 
            this.iscrtajToolStripMenuItem.Name = "iscrtajToolStripMenuItem";
            this.iscrtajToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.iscrtajToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.iscrtajToolStripMenuItem.Text = "Iscrtaj";
            this.iscrtajToolStripMenuItem.Click += new System.EventHandler(this.iscrtajToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResolution);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSelectionMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDrawMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1042, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(78, 268);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(0, 13);
            this.lblResolution.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rezolucija:";
            // 
            // lblSelectionMode
            // 
            this.lblSelectionMode.AutoSize = true;
            this.lblSelectionMode.Location = new System.Drawing.Point(98, 235);
            this.lblSelectionMode.Name = "lblSelectionMode";
            this.lblSelectionMode.Size = new System.Drawing.Size(0, 13);
            this.lblSelectionMode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oznacavanje:";
            // 
            // lblDrawMode
            // 
            this.lblDrawMode.AutoSize = true;
            this.lblDrawMode.Location = new System.Drawing.Point(66, 202);
            this.lblDrawMode.Name = "lblDrawMode";
            this.lblDrawMode.Size = new System.Drawing.Size(0, 13);
            this.lblDrawMode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crtanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trenutna slika:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(105, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(41, 44);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 13);
            this.lblY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(38, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 13);
            this.lblX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 819);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 841);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Map Editor By Dino Causevic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zid1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zid2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenkoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrac1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrac2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrac3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrac4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprijateljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprijatelj1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprijatelj2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprijatelj3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprijatelj4ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem modoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crtanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oznacavanjeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDrawMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectionMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem pogledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezolucijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x600ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x768ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iscrtajToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label label6;
    }
}

