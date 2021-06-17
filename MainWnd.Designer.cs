using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RiichiCalc.Controls;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    partial class MainWnd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel label1;
            MaterialSkin.Controls.MaterialLabel label2;
            MaterialSkin.Controls.MaterialLabel label3;
            MaterialSkin.Controls.MaterialLabel label4;
            System.Windows.Forms.Panel panel1;
            RiichiCalc.Controls.MahjongTileBtn windEastMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn windSouthMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn windWestMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn windNorthMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn dragonGreenMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn dragonRedMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn dragonWhiteMahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu1MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu2MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu3MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu4MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu5MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu6MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu7MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu8MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn pinzu9MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu1MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu2MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu3MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu4MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu5MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu6MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu7MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu8MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn souzu9MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu1MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu2MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu3MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu4MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu5MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu6MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu7MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu8MahjongTileBtn;
            RiichiCalc.Controls.MahjongTileBtn manzu9MahjongTileBtn;
            System.Windows.Forms.StatusStrip statusBar;
            System.Windows.Forms.ToolStripStatusLabel copyrightNotice;
            MaterialSkin.Controls.MaterialDivider materialDivider1;
            MaterialSkin.Controls.MaterialDivider materialDivider4;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.numeric1 = new RiichiCalc.Controls.Numeric();
            this.versionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.clearHandBtn = new MaterialSkin.Controls.MaterialButton();
            this.deck = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableWindBtn = new RiichiCalc.Controls.WindSelBtn();
            this.seatWindBtn = new RiichiCalc.Controls.WindSelBtn();
            this.winMethodEnumBtn = new RiichiCalc.Controls.WinMethodEnumBtn();
            this.betYakuEnumBtn = new RiichiCalc.Controls.BetYakuEnumBtn();
            this.extraYakuEnumBtn = new RiichiCalc.Controls.ExtraYakuEnumBtn();
            this.checkBtn1 = new RiichiCalc.Controls.CheckBtn();
            this.checkBtn2 = new RiichiCalc.Controls.CheckBtn();
            this.checkBtn3 = new RiichiCalc.Controls.CheckBtn();
            this.checkBtn4 = new RiichiCalc.Controls.CheckBtn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.test = new MaterialSkin.Controls.MaterialLabel();
            this.handCont = new RiichiCalc.Controls.MahjongTileSet();
            this.summaryBox = new MaterialSkin.Controls.MaterialListBox();
            label1 = new MaterialSkin.Controls.MaterialLabel();
            label2 = new MaterialSkin.Controls.MaterialLabel();
            label3 = new MaterialSkin.Controls.MaterialLabel();
            label4 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new System.Windows.Forms.Panel();
            windEastMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            windSouthMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            windWestMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            windNorthMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            dragonGreenMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            dragonRedMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            dragonWhiteMahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu1MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu2MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu3MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu4MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu5MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu6MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu7MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu8MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            pinzu9MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu1MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu2MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu3MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu4MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu5MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu6MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu7MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu8MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            souzu9MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu1MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu2MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu3MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu4MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu5MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu6MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu7MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu8MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            manzu9MahjongTileBtn = new RiichiCalc.Controls.MahjongTileBtn();
            statusBar = new System.Windows.Forms.StatusStrip();
            copyrightNotice = new System.Windows.Forms.ToolStripStatusLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1.SuspendLayout();
            statusBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            this.deck.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label1.Location = new System.Drawing.Point(3, 168);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 56);
            label1.TabIndex = 7;
            label1.Text = "Table wind";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Depth = 0;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label2.Location = new System.Drawing.Point(225, 168);
            label2.MouseState = MaterialSkin.MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 56);
            label2.TabIndex = 8;
            label2.Text = "Seat wind";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Depth = 0;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label3.Location = new System.Drawing.Point(225, 56);
            label3.MouseState = MaterialSkin.MouseState.HOVER;
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 56);
            label3.TabIndex = 12;
            label3.Text = "Extra yaku";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Depth = 0;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(225, 112);
            label4.MouseState = MaterialSkin.MouseState.HOVER;
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 56);
            label4.TabIndex = 13;
            label4.Text = "Dora";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.numeric1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(333, 112);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(114, 56);
            panel1.TabIndex = 14;
            // 
            // numeric1
            // 
            this.numeric1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric1.Location = new System.Drawing.Point(0, 0);
            this.numeric1.MaxValue = 10;
            this.numeric1.MinValue = 0;
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(114, 56);
            this.numeric1.TabIndex = 0;
            this.numeric1.Value = 0;
            // 
            // windEastMahjongTileBtn
            // 
            windEastMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windEastMahjongTileBtn.Location = new System.Drawing.Point(3, 3);
            windEastMahjongTileBtn.Name = "windEastMahjongTileBtn";
            windEastMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windEastMahjongTileBtn.TabIndex = 0;
            windEastMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindEast;
            windEastMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // windSouthMahjongTileBtn
            // 
            windSouthMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windSouthMahjongTileBtn.Location = new System.Drawing.Point(46, 3);
            windSouthMahjongTileBtn.Name = "windSouthMahjongTileBtn";
            windSouthMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windSouthMahjongTileBtn.TabIndex = 1;
            windSouthMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindSouth;
            windSouthMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // windWestMahjongTileBtn
            // 
            windWestMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windWestMahjongTileBtn.Location = new System.Drawing.Point(89, 3);
            windWestMahjongTileBtn.Name = "windWestMahjongTileBtn";
            windWestMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windWestMahjongTileBtn.TabIndex = 2;
            windWestMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindWest;
            windWestMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // windNorthMahjongTileBtn
            // 
            windNorthMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windNorthMahjongTileBtn.Location = new System.Drawing.Point(132, 3);
            windNorthMahjongTileBtn.Name = "windNorthMahjongTileBtn";
            windNorthMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windNorthMahjongTileBtn.TabIndex = 3;
            windNorthMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindNorth;
            windNorthMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // dragonGreenMahjongTileBtn
            // 
            dragonGreenMahjongTileBtn.ForeColor = System.Drawing.Color.Green;
            dragonGreenMahjongTileBtn.Location = new System.Drawing.Point(175, 3);
            dragonGreenMahjongTileBtn.Name = "dragonGreenMahjongTileBtn";
            dragonGreenMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonGreenMahjongTileBtn.TabIndex = 4;
            dragonGreenMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonGreen;
            dragonGreenMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // dragonRedMahjongTileBtn
            // 
            dragonRedMahjongTileBtn.ForeColor = System.Drawing.Color.DarkRed;
            dragonRedMahjongTileBtn.Location = new System.Drawing.Point(218, 3);
            dragonRedMahjongTileBtn.Name = "dragonRedMahjongTileBtn";
            dragonRedMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonRedMahjongTileBtn.TabIndex = 5;
            dragonRedMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonRed;
            dragonRedMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // dragonWhiteMahjongTileBtn
            // 
            dragonWhiteMahjongTileBtn.ForeColor = System.Drawing.Color.White;
            dragonWhiteMahjongTileBtn.Location = new System.Drawing.Point(261, 3);
            dragonWhiteMahjongTileBtn.Name = "dragonWhiteMahjongTileBtn";
            dragonWhiteMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonWhiteMahjongTileBtn.TabIndex = 6;
            dragonWhiteMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonWhite;
            dragonWhiteMahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu1MahjongTileBtn
            // 
            pinzu1MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 59);
            pinzu1MahjongTileBtn.Name = "pinzu1MahjongTileBtn";
            pinzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu1MahjongTileBtn.TabIndex = 7;
            pinzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu1;
            pinzu1MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu2MahjongTileBtn
            // 
            pinzu2MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 59);
            pinzu2MahjongTileBtn.Name = "pinzu2MahjongTileBtn";
            pinzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu2MahjongTileBtn.TabIndex = 8;
            pinzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu2;
            pinzu2MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu3MahjongTileBtn
            // 
            pinzu3MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 59);
            pinzu3MahjongTileBtn.Name = "pinzu3MahjongTileBtn";
            pinzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu3MahjongTileBtn.TabIndex = 9;
            pinzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu3;
            pinzu3MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu4MahjongTileBtn
            // 
            pinzu4MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 59);
            pinzu4MahjongTileBtn.Name = "pinzu4MahjongTileBtn";
            pinzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu4MahjongTileBtn.TabIndex = 10;
            pinzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu4;
            pinzu4MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu5MahjongTileBtn
            // 
            pinzu5MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 59);
            pinzu5MahjongTileBtn.Name = "pinzu5MahjongTileBtn";
            pinzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu5MahjongTileBtn.TabIndex = 11;
            pinzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu5;
            pinzu5MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu6MahjongTileBtn
            // 
            pinzu6MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 59);
            pinzu6MahjongTileBtn.Name = "pinzu6MahjongTileBtn";
            pinzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu6MahjongTileBtn.TabIndex = 12;
            pinzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu6;
            pinzu6MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu7MahjongTileBtn
            // 
            pinzu7MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 59);
            pinzu7MahjongTileBtn.Name = "pinzu7MahjongTileBtn";
            pinzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu7MahjongTileBtn.TabIndex = 13;
            pinzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu7;
            pinzu7MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu8MahjongTileBtn
            // 
            pinzu8MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 59);
            pinzu8MahjongTileBtn.Name = "pinzu8MahjongTileBtn";
            pinzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu8MahjongTileBtn.TabIndex = 14;
            pinzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu8;
            pinzu8MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // pinzu9MahjongTileBtn
            // 
            pinzu9MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 59);
            pinzu9MahjongTileBtn.Name = "pinzu9MahjongTileBtn";
            pinzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu9MahjongTileBtn.TabIndex = 15;
            pinzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu9;
            pinzu9MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu1MahjongTileBtn
            // 
            souzu1MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 115);
            souzu1MahjongTileBtn.Name = "souzu1MahjongTileBtn";
            souzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu1MahjongTileBtn.TabIndex = 16;
            souzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu1;
            souzu1MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu2MahjongTileBtn
            // 
            souzu2MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 115);
            souzu2MahjongTileBtn.Name = "souzu2MahjongTileBtn";
            souzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu2MahjongTileBtn.TabIndex = 17;
            souzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu2;
            souzu2MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu3MahjongTileBtn
            // 
            souzu3MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 115);
            souzu3MahjongTileBtn.Name = "souzu3MahjongTileBtn";
            souzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu3MahjongTileBtn.TabIndex = 18;
            souzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu3;
            souzu3MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu4MahjongTileBtn
            // 
            souzu4MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 115);
            souzu4MahjongTileBtn.Name = "souzu4MahjongTileBtn";
            souzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu4MahjongTileBtn.TabIndex = 19;
            souzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu4;
            souzu4MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu5MahjongTileBtn
            // 
            souzu5MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 115);
            souzu5MahjongTileBtn.Name = "souzu5MahjongTileBtn";
            souzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu5MahjongTileBtn.TabIndex = 20;
            souzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu5;
            souzu5MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu6MahjongTileBtn
            // 
            souzu6MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 115);
            souzu6MahjongTileBtn.Name = "souzu6MahjongTileBtn";
            souzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu6MahjongTileBtn.TabIndex = 21;
            souzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu6;
            souzu6MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu7MahjongTileBtn
            // 
            souzu7MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 115);
            souzu7MahjongTileBtn.Name = "souzu7MahjongTileBtn";
            souzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu7MahjongTileBtn.TabIndex = 22;
            souzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu7;
            souzu7MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu8MahjongTileBtn
            // 
            souzu8MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 115);
            souzu8MahjongTileBtn.Name = "souzu8MahjongTileBtn";
            souzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu8MahjongTileBtn.TabIndex = 23;
            souzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu8;
            souzu8MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // souzu9MahjongTileBtn
            // 
            souzu9MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 115);
            souzu9MahjongTileBtn.Name = "souzu9MahjongTileBtn";
            souzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu9MahjongTileBtn.TabIndex = 24;
            souzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu9;
            souzu9MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu1MahjongTileBtn
            // 
            manzu1MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 171);
            manzu1MahjongTileBtn.Name = "manzu1MahjongTileBtn";
            manzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu1MahjongTileBtn.TabIndex = 25;
            manzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu1;
            manzu1MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu2MahjongTileBtn
            // 
            manzu2MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 171);
            manzu2MahjongTileBtn.Name = "manzu2MahjongTileBtn";
            manzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu2MahjongTileBtn.TabIndex = 26;
            manzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu2;
            manzu2MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu3MahjongTileBtn
            // 
            manzu3MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 171);
            manzu3MahjongTileBtn.Name = "manzu3MahjongTileBtn";
            manzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu3MahjongTileBtn.TabIndex = 27;
            manzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu3;
            manzu3MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu4MahjongTileBtn
            // 
            manzu4MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 171);
            manzu4MahjongTileBtn.Name = "manzu4MahjongTileBtn";
            manzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu4MahjongTileBtn.TabIndex = 28;
            manzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu4;
            manzu4MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu5MahjongTileBtn
            // 
            manzu5MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 171);
            manzu5MahjongTileBtn.Name = "manzu5MahjongTileBtn";
            manzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu5MahjongTileBtn.TabIndex = 29;
            manzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu5;
            manzu5MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu6MahjongTileBtn
            // 
            manzu6MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 171);
            manzu6MahjongTileBtn.Name = "manzu6MahjongTileBtn";
            manzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu6MahjongTileBtn.TabIndex = 30;
            manzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu6;
            manzu6MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu7MahjongTileBtn
            // 
            manzu7MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 171);
            manzu7MahjongTileBtn.Name = "manzu7MahjongTileBtn";
            manzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu7MahjongTileBtn.TabIndex = 31;
            manzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu7;
            manzu7MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu8MahjongTileBtn
            // 
            manzu8MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 171);
            manzu8MahjongTileBtn.Name = "manzu8MahjongTileBtn";
            manzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu8MahjongTileBtn.TabIndex = 32;
            manzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu8;
            manzu8MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // manzu9MahjongTileBtn
            // 
            manzu9MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 171);
            manzu9MahjongTileBtn.Name = "manzu9MahjongTileBtn";
            manzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu9MahjongTileBtn.TabIndex = 33;
            manzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu9;
            manzu9MahjongTileBtn.Click += new System.EventHandler(this.MahjongTileBtn_Click);
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInfo,
            copyrightNotice});
            statusBar.Location = new System.Drawing.Point(3, 511);
            statusBar.Name = "statusBar";
            statusBar.Size = new System.Drawing.Size(849, 22);
            statusBar.TabIndex = 3;
            statusBar.Text = "RiichiCalc v.";
            statusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusBar_ItemClicked);
            // 
            // versionInfo
            // 
            this.versionInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.versionInfo.IsLink = true;
            this.versionInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.versionInfo.LinkColor = System.Drawing.Color.Black;
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(71, 17);
            this.versionInfo.Tag = "version_info";
            this.versionInfo.Text = "RiichiCalc v.";
            this.versionInfo.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // copyrightNotice
            // 
            copyrightNotice.Enabled = false;
            copyrightNotice.Name = "copyrightNotice";
            copyrightNotice.Size = new System.Drawing.Size(763, 17);
            copyrightNotice.Spring = true;
            copyrightNotice.Tag = "copyright_notice";
            copyrightNotice.Text = "Kacper Palka 2021";
            copyrightNotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            copyrightNotice.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialDivider1.Depth = 0;
            materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            materialDivider1.Location = new System.Drawing.Point(3, 295);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new System.Drawing.Size(849, 4);
            materialDivider1.TabIndex = 4;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialDivider4.Depth = 0;
            materialDivider4.Dock = System.Windows.Forms.DockStyle.Top;
            materialDivider4.Location = new System.Drawing.Point(3, 391);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new System.Drawing.Size(849, 4);
            materialDivider4.TabIndex = 13;
            materialDivider4.Text = "materialDivider4";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.clearHandBtn, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 299);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(849, 32);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(725, 32);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Hand";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearHandBtn
            // 
            this.clearHandBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearHandBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearHandBtn.Depth = 0;
            this.clearHandBtn.HighEmphasis = false;
            this.clearHandBtn.Icon = null;
            this.clearHandBtn.Location = new System.Drawing.Point(735, 6);
            this.clearHandBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearHandBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearHandBtn.Name = "clearHandBtn";
            this.clearHandBtn.Size = new System.Drawing.Size(110, 20);
            this.clearHandBtn.TabIndex = 7;
            this.clearHandBtn.Text = "Clear hand";
            this.clearHandBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearHandBtn.UseAccentColor = false;
            this.clearHandBtn.UseVisualStyleBackColor = true;
            this.clearHandBtn.Click += new System.EventHandler(this.clearHandBtn_Click);
            // 
            // deck
            // 
            this.deck.ColumnCount = 2;
            this.deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.deck.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.deck.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.deck.Dock = System.Windows.Forms.DockStyle.Top;
            this.deck.Location = new System.Drawing.Point(3, 65);
            this.deck.Name = "deck";
            this.deck.RowCount = 1;
            this.deck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deck.Size = new System.Drawing.Size(849, 230);
            this.deck.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableWindBtn, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.seatWindBtn, 3, 3);
            this.tableLayoutPanel3.Controls.Add(label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(label2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.winMethodEnumBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.betYakuEnumBtn, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.extraYakuEnumBtn, 3, 1);
            this.tableLayoutPanel3.Controls.Add(label3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(label4, 2, 2);
            this.tableLayoutPanel3.Controls.Add(panel1, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBtn1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBtn2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBtn3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBtn4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(399, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(447, 224);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableWindBtn
            // 
            this.tableWindBtn.AutoSize = true;
            this.tableWindBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableWindBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWindBtn.ForeColor = System.Drawing.Color.Blue;
            this.tableWindBtn.Location = new System.Drawing.Point(114, 171);
            this.tableWindBtn.Name = "tableWindBtn";
            this.tableWindBtn.Size = new System.Drawing.Size(105, 50);
            this.tableWindBtn.TabIndex = 5;
            this.tableWindBtn.Value = RiichiCalc.Tiles.MahjongWindTile.WindEast;
            this.tableWindBtn.ValueChanged += new System.EventHandler(this.tableWindBtn_ValueChanged);
            // 
            // seatWindBtn
            // 
            this.seatWindBtn.AutoSize = true;
            this.seatWindBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seatWindBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatWindBtn.ForeColor = System.Drawing.Color.Blue;
            this.seatWindBtn.Location = new System.Drawing.Point(336, 171);
            this.seatWindBtn.Name = "seatWindBtn";
            this.seatWindBtn.Size = new System.Drawing.Size(108, 50);
            this.seatWindBtn.TabIndex = 6;
            this.seatWindBtn.Value = RiichiCalc.Tiles.MahjongWindTile.WindEast;
            this.seatWindBtn.ValueChanged += new System.EventHandler(this.seatWindBtn_ValueChanged);
            // 
            // winMethodEnumBtn
            // 
            this.winMethodEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.winMethodEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winMethodEnumBtn.Location = new System.Drawing.Point(3, 59);
            this.winMethodEnumBtn.Name = "winMethodEnumBtn";
            this.winMethodEnumBtn.Size = new System.Drawing.Size(105, 50);
            this.winMethodEnumBtn.TabIndex = 9;
            this.winMethodEnumBtn.Value = RiichiCalc.Tiles.WinMethod.Tsumo;
            // 
            // betYakuEnumBtn
            // 
            this.betYakuEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.betYakuEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betYakuEnumBtn.Location = new System.Drawing.Point(114, 59);
            this.betYakuEnumBtn.Name = "betYakuEnumBtn";
            this.betYakuEnumBtn.Size = new System.Drawing.Size(105, 50);
            this.betYakuEnumBtn.TabIndex = 10;
            this.betYakuEnumBtn.Value = RiichiCalc.Tiles.BetYaku.NoRiichi;
            // 
            // extraYakuEnumBtn
            // 
            this.extraYakuEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extraYakuEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extraYakuEnumBtn.Location = new System.Drawing.Point(336, 59);
            this.extraYakuEnumBtn.Name = "extraYakuEnumBtn";
            this.extraYakuEnumBtn.Size = new System.Drawing.Size(108, 50);
            this.extraYakuEnumBtn.TabIndex = 11;
            this.extraYakuEnumBtn.Value = RiichiCalc.Tiles.ExtraYaku.None;
            // 
            // checkBtn1
            // 
            this.checkBtn1.AutoSize = true;
            this.checkBtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn1.Checked = false;
            this.checkBtn1.Content = "Pon";
            this.checkBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn1.Location = new System.Drawing.Point(3, 3);
            this.checkBtn1.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn1.Name = "checkBtn1";
            this.checkBtn1.Size = new System.Drawing.Size(105, 50);
            this.checkBtn1.TabIndex = 15;
            // 
            // checkBtn2
            // 
            this.checkBtn2.AutoSize = true;
            this.checkBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn2.Checked = false;
            this.checkBtn2.Content = "Chi";
            this.checkBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn2.Location = new System.Drawing.Point(114, 3);
            this.checkBtn2.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn2.Name = "checkBtn2";
            this.checkBtn2.Size = new System.Drawing.Size(105, 50);
            this.checkBtn2.TabIndex = 16;
            // 
            // checkBtn3
            // 
            this.checkBtn3.AutoSize = true;
            this.checkBtn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn3.Checked = false;
            this.checkBtn3.Content = "Kan";
            this.checkBtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn3.Location = new System.Drawing.Point(225, 3);
            this.checkBtn3.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn3.Name = "checkBtn3";
            this.checkBtn3.Size = new System.Drawing.Size(105, 50);
            this.checkBtn3.TabIndex = 17;
            // 
            // checkBtn4
            // 
            this.checkBtn4.AutoSize = true;
            this.checkBtn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn4.Checked = false;
            this.checkBtn4.Content = "Closed Kan";
            this.checkBtn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn4.Location = new System.Drawing.Point(336, 3);
            this.checkBtn4.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn4.Name = "checkBtn4";
            this.checkBtn4.Size = new System.Drawing.Size(108, 50);
            this.checkBtn4.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Controls.Add(windEastMahjongTileBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(windSouthMahjongTileBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(windWestMahjongTileBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(windNorthMahjongTileBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(dragonGreenMahjongTileBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(dragonWhiteMahjongTileBtn, 6, 0);
            this.tableLayoutPanel2.Controls.Add(pinzu1MahjongTileBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu2MahjongTileBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu3MahjongTileBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu4MahjongTileBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu5MahjongTileBtn, 4, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu6MahjongTileBtn, 5, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu8MahjongTileBtn, 7, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu9MahjongTileBtn, 8, 1);
            this.tableLayoutPanel2.Controls.Add(souzu1MahjongTileBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(souzu2MahjongTileBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(souzu3MahjongTileBtn, 2, 2);
            this.tableLayoutPanel2.Controls.Add(souzu4MahjongTileBtn, 3, 2);
            this.tableLayoutPanel2.Controls.Add(souzu5MahjongTileBtn, 4, 2);
            this.tableLayoutPanel2.Controls.Add(souzu6MahjongTileBtn, 5, 2);
            this.tableLayoutPanel2.Controls.Add(souzu7MahjongTileBtn, 6, 2);
            this.tableLayoutPanel2.Controls.Add(souzu8MahjongTileBtn, 7, 2);
            this.tableLayoutPanel2.Controls.Add(souzu9MahjongTileBtn, 8, 2);
            this.tableLayoutPanel2.Controls.Add(manzu1MahjongTileBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(manzu2MahjongTileBtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(manzu3MahjongTileBtn, 2, 3);
            this.tableLayoutPanel2.Controls.Add(manzu4MahjongTileBtn, 3, 3);
            this.tableLayoutPanel2.Controls.Add(manzu5MahjongTileBtn, 4, 3);
            this.tableLayoutPanel2.Controls.Add(manzu6MahjongTileBtn, 5, 3);
            this.tableLayoutPanel2.Controls.Add(manzu7MahjongTileBtn, 6, 3);
            this.tableLayoutPanel2.Controls.Add(manzu8MahjongTileBtn, 7, 3);
            this.tableLayoutPanel2.Controls.Add(manzu9MahjongTileBtn, 8, 3);
            this.tableLayoutPanel2.Controls.Add(pinzu7MahjongTileBtn, 6, 1);
            this.tableLayoutPanel2.Controls.Add(dragonRedMahjongTileBtn, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 224);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 395);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(849, 32);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Summary";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Depth = 0;
            this.test.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.test.Location = new System.Drawing.Point(12, 456);
            this.test.MouseState = MaterialSkin.MouseState.HOVER;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(44, 19);
            this.test.TabIndex = 14;
            this.test.Text = "label5";
            // 
            // handCont
            // 
            this.handCont.Dock = System.Windows.Forms.DockStyle.Top;
            this.handCont.Location = new System.Drawing.Point(3, 331);
            this.handCont.Name = "handCont";
            this.handCont.Size = new System.Drawing.Size(849, 60);
            this.handCont.TabIndex = 17;
            // 
            // summaryBox
            // 
            this.summaryBox.BackColor = System.Drawing.Color.White;
            this.summaryBox.BorderColor = System.Drawing.Color.LightGray;
            this.summaryBox.Depth = 0;
            this.summaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryBox.Enabled = false;
            this.summaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.summaryBox.Location = new System.Drawing.Point(3, 427);
            this.summaryBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.SelectedIndex = -1;
            this.summaryBox.SelectedItem = null;
            this.summaryBox.SelectedValue = null;
            this.summaryBox.Size = new System.Drawing.Size(849, 84);
            this.summaryBox.TabIndex = 19;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 536);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(materialDivider4);
            this.Controls.Add(this.handCont);
            this.Controls.Add(this.test);
            this.Controls.Add(statusBar);
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(materialDivider1);
            this.Controls.Add(this.deck);
            this.DoubleBuffered = false;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "MainWnd";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.Text = "RiichiCalc";
            panel1.ResumeLayout(false);
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.deck.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel deck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private WindSelBtn tableWindBtn;
        private WindSelBtn seatWindBtn;
        private WinMethodEnumBtn winMethodEnumBtn;
        private BetYakuEnumBtn betYakuEnumBtn;
        private ExtraYakuEnumBtn extraYakuEnumBtn;
        private CheckBtn checkBtn1;
        private CheckBtn checkBtn2;
        private CheckBtn checkBtn3;
        private CheckBtn checkBtn4;
        private System.Windows.Forms.ToolStripStatusLabel versionInfo;
        private Numeric numeric1;
        private MaterialDivider materialDivider1;
        private MaterialDivider materialDivider4;
        private MaterialLabel materialLabel2;
        private MaterialLabel test;
        private MahjongTileSet handCont;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton clearHandBtn;
        private MaterialListBox summaryBox;
    }
}

