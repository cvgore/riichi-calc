
namespace RiichiCalc.Controls
{
    partial class MahjongTileSet
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
            this.tilesSet = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tilesSet
            // 
            this.tilesSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesSet.Location = new System.Drawing.Point(0, 0);
            this.tilesSet.Name = "tilesSet";
            this.tilesSet.Size = new System.Drawing.Size(0, 0);
            this.tilesSet.TabIndex = 0;
            // 
            // MahjongTileSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tilesSet);
            this.Name = "MahjongTileSet";
            this.Size = new System.Drawing.Size(0, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tilesSet;
    }
}
