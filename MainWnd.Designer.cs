using System.Collections.Generic;
using System.Linq;
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
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
            this.doraCounter = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doraCounter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 171);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 59);
            label1.TabIndex = 7;
            label1.Text = "Table wind";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(197, 171);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 59);
            label2.TabIndex = 8;
            label2.Text = "Seat wind";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(197, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 57);
            label3.TabIndex = 12;
            label3.Text = "Extra yaku";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(197, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 57);
            label4.TabIndex = 13;
            label4.Text = "Dora";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.doraCounter);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(291, 114);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(99, 57);
            panel1.TabIndex = 14;
            // 
            // doraCounter
            // 
            this.doraCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doraCounter.Location = new System.Drawing.Point(3, 17);
            this.doraCounter.Name = "doraCounter";
            this.doraCounter.Size = new System.Drawing.Size(93, 23);
            this.doraCounter.TabIndex = 0;
            // 
            // windEastMahjongTileBtn
            // 
            windEastMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windEastMahjongTileBtn.Location = new System.Drawing.Point(3, 3);
            windEastMahjongTileBtn.Name = "windEastMahjongTileBtn";
            windEastMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windEastMahjongTileBtn.TabIndex = 0;
            windEastMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // windSouthMahjongTileBtn
            // 
            windSouthMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windSouthMahjongTileBtn.Location = new System.Drawing.Point(46, 3);
            windSouthMahjongTileBtn.Name = "windSouthMahjongTileBtn";
            windSouthMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windSouthMahjongTileBtn.TabIndex = 1;
            windSouthMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindSouth;
            // 
            // windWestMahjongTileBtn
            // 
            windWestMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windWestMahjongTileBtn.Location = new System.Drawing.Point(89, 3);
            windWestMahjongTileBtn.Name = "windWestMahjongTileBtn";
            windWestMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windWestMahjongTileBtn.TabIndex = 2;
            windWestMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindWest;
            // 
            // windNorthMahjongTileBtn
            // 
            windNorthMahjongTileBtn.ForeColor = System.Drawing.Color.Blue;
            windNorthMahjongTileBtn.Location = new System.Drawing.Point(132, 3);
            windNorthMahjongTileBtn.Name = "windNorthMahjongTileBtn";
            windNorthMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            windNorthMahjongTileBtn.TabIndex = 3;
            windNorthMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.WindNorth;
            // 
            // dragonGreenMahjongTileBtn
            // 
            dragonGreenMahjongTileBtn.ForeColor = System.Drawing.Color.Green;
            dragonGreenMahjongTileBtn.Location = new System.Drawing.Point(175, 3);
            dragonGreenMahjongTileBtn.Name = "dragonGreenMahjongTileBtn";
            dragonGreenMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonGreenMahjongTileBtn.TabIndex = 4;
            dragonGreenMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonGreen;
            // 
            // dragonRedMahjongTileBtn
            // 
            dragonRedMahjongTileBtn.ForeColor = System.Drawing.Color.DarkRed;
            dragonRedMahjongTileBtn.Location = new System.Drawing.Point(218, 3);
            dragonRedMahjongTileBtn.Name = "dragonRedMahjongTileBtn";
            dragonRedMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonRedMahjongTileBtn.TabIndex = 5;
            dragonRedMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonRed;
            // 
            // dragonWhiteMahjongTileBtn
            // 
            dragonWhiteMahjongTileBtn.ForeColor = System.Drawing.Color.White;
            dragonWhiteMahjongTileBtn.Location = new System.Drawing.Point(261, 3);
            dragonWhiteMahjongTileBtn.Name = "dragonWhiteMahjongTileBtn";
            dragonWhiteMahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            dragonWhiteMahjongTileBtn.TabIndex = 6;
            dragonWhiteMahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.DragonWhite;
            // 
            // pinzu1MahjongTileBtn
            // 
            pinzu1MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 60);
            pinzu1MahjongTileBtn.Name = "pinzu1MahjongTileBtn";
            pinzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu1MahjongTileBtn.TabIndex = 7;
            pinzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu1;
            // 
            // pinzu2MahjongTileBtn
            // 
            pinzu2MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 60);
            pinzu2MahjongTileBtn.Name = "pinzu2MahjongTileBtn";
            pinzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu2MahjongTileBtn.TabIndex = 8;
            pinzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu2;
            // 
            // pinzu3MahjongTileBtn
            // 
            pinzu3MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 60);
            pinzu3MahjongTileBtn.Name = "pinzu3MahjongTileBtn";
            pinzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu3MahjongTileBtn.TabIndex = 9;
            pinzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu3;
            // 
            // pinzu4MahjongTileBtn
            // 
            pinzu4MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 60);
            pinzu4MahjongTileBtn.Name = "pinzu4MahjongTileBtn";
            pinzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu4MahjongTileBtn.TabIndex = 10;
            pinzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu4;
            // 
            // pinzu5MahjongTileBtn
            // 
            pinzu5MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 60);
            pinzu5MahjongTileBtn.Name = "pinzu5MahjongTileBtn";
            pinzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu5MahjongTileBtn.TabIndex = 11;
            pinzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu5;
            // 
            // pinzu6MahjongTileBtn
            // 
            pinzu6MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 60);
            pinzu6MahjongTileBtn.Name = "pinzu6MahjongTileBtn";
            pinzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu6MahjongTileBtn.TabIndex = 12;
            pinzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu6;
            // 
            // pinzu7MahjongTileBtn
            // 
            pinzu7MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 60);
            pinzu7MahjongTileBtn.Name = "pinzu7MahjongTileBtn";
            pinzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu7MahjongTileBtn.TabIndex = 13;
            pinzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu7;
            // 
            // pinzu8MahjongTileBtn
            // 
            pinzu8MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 60);
            pinzu8MahjongTileBtn.Name = "pinzu8MahjongTileBtn";
            pinzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu8MahjongTileBtn.TabIndex = 14;
            pinzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu8;
            // 
            // pinzu9MahjongTileBtn
            // 
            pinzu9MahjongTileBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            pinzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 60);
            pinzu9MahjongTileBtn.Name = "pinzu9MahjongTileBtn";
            pinzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            pinzu9MahjongTileBtn.TabIndex = 15;
            pinzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu9;
            // 
            // souzu1MahjongTileBtn
            // 
            souzu1MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 117);
            souzu1MahjongTileBtn.Name = "souzu1MahjongTileBtn";
            souzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu1MahjongTileBtn.TabIndex = 16;
            souzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu1;
            // 
            // souzu2MahjongTileBtn
            // 
            souzu2MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 117);
            souzu2MahjongTileBtn.Name = "souzu2MahjongTileBtn";
            souzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu2MahjongTileBtn.TabIndex = 17;
            souzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu2;
            // 
            // souzu3MahjongTileBtn
            // 
            souzu3MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 117);
            souzu3MahjongTileBtn.Name = "souzu3MahjongTileBtn";
            souzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu3MahjongTileBtn.TabIndex = 18;
            souzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu3;
            // 
            // souzu4MahjongTileBtn
            // 
            souzu4MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 117);
            souzu4MahjongTileBtn.Name = "souzu4MahjongTileBtn";
            souzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu4MahjongTileBtn.TabIndex = 19;
            souzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu4;
            // 
            // souzu5MahjongTileBtn
            // 
            souzu5MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 117);
            souzu5MahjongTileBtn.Name = "souzu5MahjongTileBtn";
            souzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu5MahjongTileBtn.TabIndex = 20;
            souzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu5;
            // 
            // souzu6MahjongTileBtn
            // 
            souzu6MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 117);
            souzu6MahjongTileBtn.Name = "souzu6MahjongTileBtn";
            souzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu6MahjongTileBtn.TabIndex = 21;
            souzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu6;
            // 
            // souzu7MahjongTileBtn
            // 
            souzu7MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 117);
            souzu7MahjongTileBtn.Name = "souzu7MahjongTileBtn";
            souzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu7MahjongTileBtn.TabIndex = 22;
            souzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu7;
            // 
            // souzu8MahjongTileBtn
            // 
            souzu8MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 117);
            souzu8MahjongTileBtn.Name = "souzu8MahjongTileBtn";
            souzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu8MahjongTileBtn.TabIndex = 23;
            souzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu8;
            // 
            // souzu9MahjongTileBtn
            // 
            souzu9MahjongTileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            souzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 117);
            souzu9MahjongTileBtn.Name = "souzu9MahjongTileBtn";
            souzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            souzu9MahjongTileBtn.TabIndex = 24;
            souzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Souzu9;
            // 
            // manzu1MahjongTileBtn
            // 
            manzu1MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu1MahjongTileBtn.Location = new System.Drawing.Point(3, 174);
            manzu1MahjongTileBtn.Name = "manzu1MahjongTileBtn";
            manzu1MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu1MahjongTileBtn.TabIndex = 25;
            manzu1MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu1;
            // 
            // manzu2MahjongTileBtn
            // 
            manzu2MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu2MahjongTileBtn.Location = new System.Drawing.Point(46, 174);
            manzu2MahjongTileBtn.Name = "manzu2MahjongTileBtn";
            manzu2MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu2MahjongTileBtn.TabIndex = 26;
            manzu2MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu2;
            // 
            // manzu3MahjongTileBtn
            // 
            manzu3MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu3MahjongTileBtn.Location = new System.Drawing.Point(89, 174);
            manzu3MahjongTileBtn.Name = "manzu3MahjongTileBtn";
            manzu3MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu3MahjongTileBtn.TabIndex = 27;
            manzu3MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu3;
            // 
            // manzu4MahjongTileBtn
            // 
            manzu4MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu4MahjongTileBtn.Location = new System.Drawing.Point(132, 174);
            manzu4MahjongTileBtn.Name = "manzu4MahjongTileBtn";
            manzu4MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu4MahjongTileBtn.TabIndex = 28;
            manzu4MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu4;
            // 
            // manzu5MahjongTileBtn
            // 
            manzu5MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu5MahjongTileBtn.Location = new System.Drawing.Point(175, 174);
            manzu5MahjongTileBtn.Name = "manzu5MahjongTileBtn";
            manzu5MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu5MahjongTileBtn.TabIndex = 29;
            manzu5MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu5;
            // 
            // manzu6MahjongTileBtn
            // 
            manzu6MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu6MahjongTileBtn.Location = new System.Drawing.Point(218, 174);
            manzu6MahjongTileBtn.Name = "manzu6MahjongTileBtn";
            manzu6MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu6MahjongTileBtn.TabIndex = 30;
            manzu6MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu6;
            // 
            // manzu7MahjongTileBtn
            // 
            manzu7MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu7MahjongTileBtn.Location = new System.Drawing.Point(261, 174);
            manzu7MahjongTileBtn.Name = "manzu7MahjongTileBtn";
            manzu7MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu7MahjongTileBtn.TabIndex = 31;
            manzu7MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu7;
            // 
            // manzu8MahjongTileBtn
            // 
            manzu8MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu8MahjongTileBtn.Location = new System.Drawing.Point(304, 174);
            manzu8MahjongTileBtn.Name = "manzu8MahjongTileBtn";
            manzu8MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu8MahjongTileBtn.TabIndex = 32;
            manzu8MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu8;
            // 
            // manzu9MahjongTileBtn
            // 
            manzu9MahjongTileBtn.ForeColor = System.Drawing.Color.DarkBlue;
            manzu9MahjongTileBtn.Location = new System.Drawing.Point(347, 174);
            manzu9MahjongTileBtn.Name = "manzu9MahjongTileBtn";
            manzu9MahjongTileBtn.Size = new System.Drawing.Size(35, 50);
            manzu9MahjongTileBtn.TabIndex = 33;
            manzu9MahjongTileBtn.Tile = RiichiCalc.Tiles.MahjongTile.Manzu9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 236);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Controls.Add(dragonRedMahjongTileBtn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(dragonWhiteMahjongTileBtn, 6, 0);
            this.tableLayoutPanel2.Controls.Add(pinzu1MahjongTileBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu2MahjongTileBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu3MahjongTileBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu4MahjongTileBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu5MahjongTileBtn, 4, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu6MahjongTileBtn, 5, 1);
            this.tableLayoutPanel2.Controls.Add(pinzu7MahjongTileBtn, 6, 1);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 230);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(390, 230);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableWindBtn
            // 
            this.tableWindBtn.AutoSize = true;
            this.tableWindBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableWindBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWindBtn.Location = new System.Drawing.Point(100, 174);
            this.tableWindBtn.Name = "tableWindBtn";
            this.tableWindBtn.Size = new System.Drawing.Size(91, 53);
            this.tableWindBtn.TabIndex = 5;
            this.tableWindBtn.Value = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // seatWindBtn
            // 
            this.seatWindBtn.AutoSize = true;
            this.seatWindBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seatWindBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatWindBtn.Location = new System.Drawing.Point(294, 174);
            this.seatWindBtn.Name = "seatWindBtn";
            this.seatWindBtn.Size = new System.Drawing.Size(93, 53);
            this.seatWindBtn.TabIndex = 6;
            this.seatWindBtn.Value = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // winMethodEnumBtn
            // 
            this.winMethodEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.winMethodEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winMethodEnumBtn.Location = new System.Drawing.Point(3, 60);
            this.winMethodEnumBtn.Name = "winMethodEnumBtn";
            this.winMethodEnumBtn.Size = new System.Drawing.Size(91, 51);
            this.winMethodEnumBtn.TabIndex = 9;
            this.winMethodEnumBtn.Value = RiichiCalc.Tiles.WinMethod.Tsumo;
            // 
            // betYakuEnumBtn
            // 
            this.betYakuEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.betYakuEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betYakuEnumBtn.Location = new System.Drawing.Point(100, 60);
            this.betYakuEnumBtn.Name = "betYakuEnumBtn";
            this.betYakuEnumBtn.Size = new System.Drawing.Size(91, 51);
            this.betYakuEnumBtn.TabIndex = 10;
            this.betYakuEnumBtn.Value = RiichiCalc.Tiles.BetYaku.NoRiichi;
            // 
            // extraYakuEnumBtn
            // 
            this.extraYakuEnumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extraYakuEnumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extraYakuEnumBtn.Location = new System.Drawing.Point(294, 60);
            this.extraYakuEnumBtn.Name = "extraYakuEnumBtn";
            this.extraYakuEnumBtn.Size = new System.Drawing.Size(93, 51);
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
            this.checkBtn1.Size = new System.Drawing.Size(91, 51);
            this.checkBtn1.TabIndex = 15;
            // 
            // checkBtn2
            // 
            this.checkBtn2.AutoSize = true;
            this.checkBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn2.Checked = false;
            this.checkBtn2.Content = "Chi";
            this.checkBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn2.Location = new System.Drawing.Point(100, 3);
            this.checkBtn2.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn2.Name = "checkBtn2";
            this.checkBtn2.Size = new System.Drawing.Size(91, 51);
            this.checkBtn2.TabIndex = 16;
            // 
            // checkBtn3
            // 
            this.checkBtn3.AutoSize = true;
            this.checkBtn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn3.Checked = false;
            this.checkBtn3.Content = "Kan";
            this.checkBtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn3.Location = new System.Drawing.Point(197, 3);
            this.checkBtn3.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn3.Name = "checkBtn3";
            this.checkBtn3.Size = new System.Drawing.Size(91, 51);
            this.checkBtn3.TabIndex = 17;
            // 
            // checkBtn4
            // 
            this.checkBtn4.AutoSize = true;
            this.checkBtn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn4.Checked = false;
            this.checkBtn4.Content = "Closed Kan";
            this.checkBtn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBtn4.Location = new System.Drawing.Point(294, 3);
            this.checkBtn4.MinimumSize = new System.Drawing.Size(75, 25);
            this.checkBtn4.Name = "checkBtn4";
            this.checkBtn4.Size = new System.Drawing.Size(93, 51);
            this.checkBtn4.TabIndex = 18;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "MainWnd";
            this.Text = "RiichiCalc";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doraCounter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private WindSelBtn tableWindBtn;
        private WindSelBtn seatWindBtn;
        private WinMethodEnumBtn winMethodEnumBtn;
        private BetYakuEnumBtn betYakuEnumBtn;
        private ExtraYakuEnumBtn extraYakuEnumBtn;
        private System.Windows.Forms.NumericUpDown doraCounter;
        private CheckBtn checkBtn1;
        private CheckBtn checkBtn2;
        private CheckBtn checkBtn3;
        private CheckBtn checkBtn4;
    }
}

