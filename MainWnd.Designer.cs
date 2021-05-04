using System.Collections.Generic;
using System.Linq;
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
            this.tilesPane = new System.Windows.Forms.Panel();
            this.tilesPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilesPane
            // 
            this.tilesPane.AutoSize = true;
            this.tilesPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tilesPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.tilesPane.Location = new System.Drawing.Point(0, 0);
            this.tilesPane.Name = "tilesPane";
            this.tilesPane.Padding = new System.Windows.Forms.Padding(16);
            this.tilesPane.Size = new System.Drawing.Size(784, 56);
            this.tilesPane.TabIndex = 1;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tilesPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWnd";
            this.Text = "RiichiCalc";

            this.tilesPane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel tilesPane;
    }
}

