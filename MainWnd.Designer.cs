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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mahjongTileBtn1 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn2 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn3 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn4 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn5 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn6 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn7 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn8 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn9 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn10 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn11 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn12 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn13 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn14 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn15 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn16 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn17 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn18 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn19 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn20 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn21 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn22 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn23 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn24 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn25 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn26 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn27 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn28 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn29 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn30 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn31 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn32 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn33 = new RiichiCalc.Controls.MahjongTileBtn();
            this.mahjongTileBtn34 = new RiichiCalc.Controls.MahjongTileBtn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.windSelBtn1 = new RiichiCalc.Controls.WindSelBtn();
            this.windSelBtn2 = new RiichiCalc.Controls.WindSelBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winMethodEnumBtn1 = new RiichiCalc.Controls.WinMethodEnumBtn();
            this.betYakuEnumBtn1 = new RiichiCalc.Controls.BetYakuEnumBtn();
            this.extraYakuEnumBtn1 = new RiichiCalc.Controls.ExtraYakuEnumBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn10, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn11, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn12, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn13, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn14, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn15, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn16, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn18, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn19, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn20, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn21, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn22, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn23, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn24, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn25, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn27, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn28, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn29, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn30, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn31, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn32, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn33, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.mahjongTileBtn34, 8, 3);
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
            // mahjongTileBtn1
            // 
            this.mahjongTileBtn1.ForeColor = System.Drawing.Color.Blue;
            this.mahjongTileBtn1.Location = new System.Drawing.Point(3, 3);
            this.mahjongTileBtn1.Name = "mahjongTileBtn1";
            this.mahjongTileBtn1.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn1.TabIndex = 0;
            this.mahjongTileBtn1.Tile = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // mahjongTileBtn2
            // 
            this.mahjongTileBtn2.ForeColor = System.Drawing.Color.Blue;
            this.mahjongTileBtn2.Location = new System.Drawing.Point(46, 3);
            this.mahjongTileBtn2.Name = "mahjongTileBtn2";
            this.mahjongTileBtn2.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn2.TabIndex = 1;
            this.mahjongTileBtn2.Tile = RiichiCalc.Tiles.MahjongTile.WindSouth;
            // 
            // mahjongTileBtn3
            // 
            this.mahjongTileBtn3.ForeColor = System.Drawing.Color.Blue;
            this.mahjongTileBtn3.Location = new System.Drawing.Point(89, 3);
            this.mahjongTileBtn3.Name = "mahjongTileBtn3";
            this.mahjongTileBtn3.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn3.TabIndex = 2;
            this.mahjongTileBtn3.Tile = RiichiCalc.Tiles.MahjongTile.WindWest;
            // 
            // mahjongTileBtn4
            // 
            this.mahjongTileBtn4.ForeColor = System.Drawing.Color.Blue;
            this.mahjongTileBtn4.Location = new System.Drawing.Point(132, 3);
            this.mahjongTileBtn4.Name = "mahjongTileBtn4";
            this.mahjongTileBtn4.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn4.TabIndex = 3;
            this.mahjongTileBtn4.Tile = RiichiCalc.Tiles.MahjongTile.WindNorth;
            // 
            // mahjongTileBtn5
            // 
            this.mahjongTileBtn5.ForeColor = System.Drawing.Color.Green;
            this.mahjongTileBtn5.Location = new System.Drawing.Point(175, 3);
            this.mahjongTileBtn5.Name = "mahjongTileBtn5";
            this.mahjongTileBtn5.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn5.TabIndex = 4;
            this.mahjongTileBtn5.Tile = RiichiCalc.Tiles.MahjongTile.DragonGreen;
            // 
            // mahjongTileBtn6
            // 
            this.mahjongTileBtn6.ForeColor = System.Drawing.Color.DarkRed;
            this.mahjongTileBtn6.Location = new System.Drawing.Point(218, 3);
            this.mahjongTileBtn6.Name = "mahjongTileBtn6";
            this.mahjongTileBtn6.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn6.TabIndex = 5;
            this.mahjongTileBtn6.Tile = RiichiCalc.Tiles.MahjongTile.DragonRed;
            // 
            // mahjongTileBtn7
            // 
            this.mahjongTileBtn7.ForeColor = System.Drawing.Color.White;
            this.mahjongTileBtn7.Location = new System.Drawing.Point(261, 3);
            this.mahjongTileBtn7.Name = "mahjongTileBtn7";
            this.mahjongTileBtn7.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn7.TabIndex = 6;
            this.mahjongTileBtn7.Tile = RiichiCalc.Tiles.MahjongTile.DragonWhite;
            // 
            // mahjongTileBtn8
            // 
            this.mahjongTileBtn8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn8.Location = new System.Drawing.Point(3, 60);
            this.mahjongTileBtn8.Name = "mahjongTileBtn8";
            this.mahjongTileBtn8.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn8.TabIndex = 7;
            this.mahjongTileBtn8.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu1;
            // 
            // mahjongTileBtn9
            // 
            this.mahjongTileBtn9.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn9.Location = new System.Drawing.Point(46, 60);
            this.mahjongTileBtn9.Name = "mahjongTileBtn9";
            this.mahjongTileBtn9.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn9.TabIndex = 8;
            this.mahjongTileBtn9.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu2;
            // 
            // mahjongTileBtn10
            // 
            this.mahjongTileBtn10.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn10.Location = new System.Drawing.Point(89, 60);
            this.mahjongTileBtn10.Name = "mahjongTileBtn10";
            this.mahjongTileBtn10.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn10.TabIndex = 9;
            this.mahjongTileBtn10.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu3;
            // 
            // mahjongTileBtn11
            // 
            this.mahjongTileBtn11.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn11.Location = new System.Drawing.Point(132, 60);
            this.mahjongTileBtn11.Name = "mahjongTileBtn11";
            this.mahjongTileBtn11.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn11.TabIndex = 10;
            this.mahjongTileBtn11.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu4;
            // 
            // mahjongTileBtn12
            // 
            this.mahjongTileBtn12.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn12.Location = new System.Drawing.Point(175, 60);
            this.mahjongTileBtn12.Name = "mahjongTileBtn12";
            this.mahjongTileBtn12.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn12.TabIndex = 11;
            this.mahjongTileBtn12.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu5;
            // 
            // mahjongTileBtn13
            // 
            this.mahjongTileBtn13.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn13.Location = new System.Drawing.Point(218, 60);
            this.mahjongTileBtn13.Name = "mahjongTileBtn13";
            this.mahjongTileBtn13.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn13.TabIndex = 12;
            this.mahjongTileBtn13.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu6;
            // 
            // mahjongTileBtn14
            // 
            this.mahjongTileBtn14.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn14.Location = new System.Drawing.Point(261, 60);
            this.mahjongTileBtn14.Name = "mahjongTileBtn14";
            this.mahjongTileBtn14.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn14.TabIndex = 13;
            this.mahjongTileBtn14.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu7;
            // 
            // mahjongTileBtn15
            // 
            this.mahjongTileBtn15.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn15.Location = new System.Drawing.Point(304, 60);
            this.mahjongTileBtn15.Name = "mahjongTileBtn15";
            this.mahjongTileBtn15.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn15.TabIndex = 14;
            this.mahjongTileBtn15.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu8;
            // 
            // mahjongTileBtn16
            // 
            this.mahjongTileBtn16.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.mahjongTileBtn16.Location = new System.Drawing.Point(347, 60);
            this.mahjongTileBtn16.Name = "mahjongTileBtn16";
            this.mahjongTileBtn16.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn16.TabIndex = 15;
            this.mahjongTileBtn16.Tile = RiichiCalc.Tiles.MahjongTile.Pinzu9;
            // 
            // mahjongTileBtn17
            // 
            this.mahjongTileBtn17.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn17.Location = new System.Drawing.Point(3, 117);
            this.mahjongTileBtn17.Name = "mahjongTileBtn17";
            this.mahjongTileBtn17.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn17.TabIndex = 16;
            this.mahjongTileBtn17.Tile = RiichiCalc.Tiles.MahjongTile.Souzu1;
            // 
            // mahjongTileBtn18
            // 
            this.mahjongTileBtn18.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn18.Location = new System.Drawing.Point(46, 117);
            this.mahjongTileBtn18.Name = "mahjongTileBtn18";
            this.mahjongTileBtn18.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn18.TabIndex = 17;
            this.mahjongTileBtn18.Tile = RiichiCalc.Tiles.MahjongTile.Souzu2;
            // 
            // mahjongTileBtn19
            // 
            this.mahjongTileBtn19.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn19.Location = new System.Drawing.Point(89, 117);
            this.mahjongTileBtn19.Name = "mahjongTileBtn19";
            this.mahjongTileBtn19.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn19.TabIndex = 18;
            this.mahjongTileBtn19.Tile = RiichiCalc.Tiles.MahjongTile.Souzu3;
            // 
            // mahjongTileBtn20
            // 
            this.mahjongTileBtn20.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn20.Location = new System.Drawing.Point(132, 117);
            this.mahjongTileBtn20.Name = "mahjongTileBtn20";
            this.mahjongTileBtn20.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn20.TabIndex = 19;
            this.mahjongTileBtn20.Tile = RiichiCalc.Tiles.MahjongTile.Souzu4;
            // 
            // mahjongTileBtn21
            // 
            this.mahjongTileBtn21.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn21.Location = new System.Drawing.Point(175, 117);
            this.mahjongTileBtn21.Name = "mahjongTileBtn21";
            this.mahjongTileBtn21.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn21.TabIndex = 20;
            this.mahjongTileBtn21.Tile = RiichiCalc.Tiles.MahjongTile.Souzu5;
            // 
            // mahjongTileBtn22
            // 
            this.mahjongTileBtn22.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn22.Location = new System.Drawing.Point(218, 117);
            this.mahjongTileBtn22.Name = "mahjongTileBtn22";
            this.mahjongTileBtn22.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn22.TabIndex = 21;
            this.mahjongTileBtn22.Tile = RiichiCalc.Tiles.MahjongTile.Souzu6;
            // 
            // mahjongTileBtn23
            // 
            this.mahjongTileBtn23.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn23.Location = new System.Drawing.Point(261, 117);
            this.mahjongTileBtn23.Name = "mahjongTileBtn23";
            this.mahjongTileBtn23.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn23.TabIndex = 22;
            this.mahjongTileBtn23.Tile = RiichiCalc.Tiles.MahjongTile.Souzu7;
            // 
            // mahjongTileBtn24
            // 
            this.mahjongTileBtn24.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn24.Location = new System.Drawing.Point(304, 117);
            this.mahjongTileBtn24.Name = "mahjongTileBtn24";
            this.mahjongTileBtn24.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn24.TabIndex = 23;
            this.mahjongTileBtn24.Tile = RiichiCalc.Tiles.MahjongTile.Souzu8;
            // 
            // mahjongTileBtn25
            // 
            this.mahjongTileBtn25.ForeColor = System.Drawing.Color.DarkGreen;
            this.mahjongTileBtn25.Location = new System.Drawing.Point(347, 117);
            this.mahjongTileBtn25.Name = "mahjongTileBtn25";
            this.mahjongTileBtn25.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn25.TabIndex = 24;
            this.mahjongTileBtn25.Tile = RiichiCalc.Tiles.MahjongTile.Souzu9;
            // 
            // mahjongTileBtn26
            // 
            this.mahjongTileBtn26.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn26.Location = new System.Drawing.Point(3, 174);
            this.mahjongTileBtn26.Name = "mahjongTileBtn26";
            this.mahjongTileBtn26.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn26.TabIndex = 25;
            this.mahjongTileBtn26.Tile = RiichiCalc.Tiles.MahjongTile.Manzu1;
            // 
            // mahjongTileBtn27
            // 
            this.mahjongTileBtn27.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn27.Location = new System.Drawing.Point(46, 174);
            this.mahjongTileBtn27.Name = "mahjongTileBtn27";
            this.mahjongTileBtn27.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn27.TabIndex = 26;
            this.mahjongTileBtn27.Tile = RiichiCalc.Tiles.MahjongTile.Manzu2;
            // 
            // mahjongTileBtn28
            // 
            this.mahjongTileBtn28.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn28.Location = new System.Drawing.Point(89, 174);
            this.mahjongTileBtn28.Name = "mahjongTileBtn28";
            this.mahjongTileBtn28.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn28.TabIndex = 27;
            this.mahjongTileBtn28.Tile = RiichiCalc.Tiles.MahjongTile.Manzu3;
            // 
            // mahjongTileBtn29
            // 
            this.mahjongTileBtn29.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn29.Location = new System.Drawing.Point(132, 174);
            this.mahjongTileBtn29.Name = "mahjongTileBtn29";
            this.mahjongTileBtn29.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn29.TabIndex = 28;
            this.mahjongTileBtn29.Tile = RiichiCalc.Tiles.MahjongTile.Manzu4;
            // 
            // mahjongTileBtn30
            // 
            this.mahjongTileBtn30.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn30.Location = new System.Drawing.Point(175, 174);
            this.mahjongTileBtn30.Name = "mahjongTileBtn30";
            this.mahjongTileBtn30.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn30.TabIndex = 29;
            this.mahjongTileBtn30.Tile = RiichiCalc.Tiles.MahjongTile.Manzu5;
            // 
            // mahjongTileBtn31
            // 
            this.mahjongTileBtn31.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn31.Location = new System.Drawing.Point(218, 174);
            this.mahjongTileBtn31.Name = "mahjongTileBtn31";
            this.mahjongTileBtn31.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn31.TabIndex = 30;
            this.mahjongTileBtn31.Tile = RiichiCalc.Tiles.MahjongTile.Manzu6;
            // 
            // mahjongTileBtn32
            // 
            this.mahjongTileBtn32.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn32.Location = new System.Drawing.Point(261, 174);
            this.mahjongTileBtn32.Name = "mahjongTileBtn32";
            this.mahjongTileBtn32.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn32.TabIndex = 31;
            this.mahjongTileBtn32.Tile = RiichiCalc.Tiles.MahjongTile.Manzu7;
            // 
            // mahjongTileBtn33
            // 
            this.mahjongTileBtn33.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn33.Location = new System.Drawing.Point(304, 174);
            this.mahjongTileBtn33.Name = "mahjongTileBtn33";
            this.mahjongTileBtn33.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn33.TabIndex = 32;
            this.mahjongTileBtn33.Tile = RiichiCalc.Tiles.MahjongTile.Manzu8;
            // 
            // mahjongTileBtn34
            // 
            this.mahjongTileBtn34.ForeColor = System.Drawing.Color.DarkBlue;
            this.mahjongTileBtn34.Location = new System.Drawing.Point(347, 174);
            this.mahjongTileBtn34.Name = "mahjongTileBtn34";
            this.mahjongTileBtn34.Size = new System.Drawing.Size(35, 50);
            this.mahjongTileBtn34.TabIndex = 33;
            this.mahjongTileBtn34.Tile = RiichiCalc.Tiles.MahjongTile.Manzu9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.windSelBtn1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.windSelBtn2, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.winMethodEnumBtn1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.betYakuEnumBtn1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.extraYakuEnumBtn1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 1);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pon";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(100, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(197, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(294, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Closed Kan";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // windSelBtn1
            // 
            this.windSelBtn1.AutoSize = true;
            this.windSelBtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windSelBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windSelBtn1.Location = new System.Drawing.Point(100, 174);
            this.windSelBtn1.Name = "windSelBtn1";
            this.windSelBtn1.Size = new System.Drawing.Size(91, 53);
            this.windSelBtn1.TabIndex = 5;
            this.windSelBtn1.Value = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // windSelBtn2
            // 
            this.windSelBtn2.AutoSize = true;
            this.windSelBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windSelBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windSelBtn2.Location = new System.Drawing.Point(294, 174);
            this.windSelBtn2.Name = "windSelBtn2";
            this.windSelBtn2.Size = new System.Drawing.Size(93, 53);
            this.windSelBtn2.TabIndex = 6;
            this.windSelBtn2.Value = RiichiCalc.Tiles.MahjongTile.WindEast;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Table wind";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(197, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 59);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seat wind";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // winMethodEnumBtn1
            // 
            this.winMethodEnumBtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.winMethodEnumBtn1.Location = new System.Drawing.Point(3, 60);
            this.winMethodEnumBtn1.Name = "winMethodEnumBtn1";
            this.winMethodEnumBtn1.Size = new System.Drawing.Size(91, 51);
            this.winMethodEnumBtn1.TabIndex = 9;
            this.winMethodEnumBtn1.Value = RiichiCalc.Tiles.WinMethod.Tsumo;
            // 
            // betYakuEnumBtn1
            // 
            this.betYakuEnumBtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.betYakuEnumBtn1.Location = new System.Drawing.Point(100, 60);
            this.betYakuEnumBtn1.Name = "betYakuEnumBtn1";
            this.betYakuEnumBtn1.Size = new System.Drawing.Size(91, 51);
            this.betYakuEnumBtn1.TabIndex = 10;
            this.betYakuEnumBtn1.Value = RiichiCalc.Tiles.BetYaku.NoRiichi;
            // 
            // extraYakuEnumBtn1
            // 
            this.extraYakuEnumBtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extraYakuEnumBtn1.Location = new System.Drawing.Point(294, 60);
            this.extraYakuEnumBtn1.Name = "extraYakuEnumBtn1";
            this.extraYakuEnumBtn1.Size = new System.Drawing.Size(91, 51);
            this.extraYakuEnumBtn1.TabIndex = 11;
            this.extraYakuEnumBtn1.Value = RiichiCalc.Tiles.ExtraYaku.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(197, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 57);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extra yaku";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "MainWnd";
            this.Text = "RiichiCalc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MahjongTileBtn mahjongTileBtn1;
        private MahjongTileBtn mahjongTileBtn2;
        private MahjongTileBtn mahjongTileBtn3;
        private MahjongTileBtn mahjongTileBtn4;
        private MahjongTileBtn mahjongTileBtn5;
        private MahjongTileBtn mahjongTileBtn6;
        private MahjongTileBtn mahjongTileBtn7;
        private MahjongTileBtn mahjongTileBtn8;
        private MahjongTileBtn mahjongTileBtn9;
        private MahjongTileBtn mahjongTileBtn10;
        private MahjongTileBtn mahjongTileBtn11;
        private MahjongTileBtn mahjongTileBtn12;
        private MahjongTileBtn mahjongTileBtn13;
        private MahjongTileBtn mahjongTileBtn14;
        private MahjongTileBtn mahjongTileBtn15;
        private MahjongTileBtn mahjongTileBtn16;
        private MahjongTileBtn mahjongTileBtn17;
        private MahjongTileBtn mahjongTileBtn18;
        private MahjongTileBtn mahjongTileBtn19;
        private MahjongTileBtn mahjongTileBtn20;
        private MahjongTileBtn mahjongTileBtn21;
        private MahjongTileBtn mahjongTileBtn22;
        private MahjongTileBtn mahjongTileBtn23;
        private MahjongTileBtn mahjongTileBtn24;
        private MahjongTileBtn mahjongTileBtn25;
        private MahjongTileBtn mahjongTileBtn26;
        private MahjongTileBtn mahjongTileBtn27;
        private MahjongTileBtn mahjongTileBtn28;
        private MahjongTileBtn mahjongTileBtn29;
        private MahjongTileBtn mahjongTileBtn30;
        private MahjongTileBtn mahjongTileBtn31;
        private MahjongTileBtn mahjongTileBtn32;
        private MahjongTileBtn mahjongTileBtn33;
        private MahjongTileBtn mahjongTileBtn34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private WindSelBtn windSelBtn1;
        private WindSelBtn windSelBtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinMethodEnumBtn winMethodEnumBtn1;
        private BetYakuEnumBtn betYakuEnumBtn1;
        private ExtraYakuEnumBtn extraYakuEnumBtn1;
        private System.Windows.Forms.Label label3;
    }
}

