﻿using System.Drawing;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    partial class MahjongTileBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tileBtn = new System.Windows.Forms.Button();
            this.tileTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tileBtn
            // 
            this.tileBtn.AutoSize = true;
            this.tileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBtn.Location = new System.Drawing.Point(0, 0);
            this.tileBtn.Name = "tileBtn";
            this.tileBtn.Size = new System.Drawing.Size(40, 60);
            this.tileBtn.TabIndex = 0;
            this.tileBtn.UseCompatibleTextRendering = true;
            this.tileBtn.UseVisualStyleBackColor = true;
            // 
            // tileTip
            // 
            this.tileTip.AutomaticDelay = 250;
            this.tileTip.IsBalloon = true;
            this.tileTip.ShowAlways = true;
            // 
            // MahjongTileBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileBtn);
            this.Name = "MahjongTileBtn";
            this.Size = new System.Drawing.Size(40, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tileBtn;
        private System.Windows.Forms.ToolTip tileTip;
    }
}
