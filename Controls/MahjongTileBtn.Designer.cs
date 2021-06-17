namespace RiichiCalc.Controls
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
            this.tileBtn = new RiichiCalc.Controls.MaterialButton();
            this.tileTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tileBtn
            // 
            this.tileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tileBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tileBtn.Depth = 0;
            this.tileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBtn.FlatAppearance.BorderSize = 0;
            this.tileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileBtn.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tileBtn.HighEmphasis = true;
            this.tileBtn.Icon = null;
            this.tileBtn.Location = new System.Drawing.Point(0, 0);
            this.tileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.tileBtn.Name = "tileBtn";
            this.tileBtn.Size = new System.Drawing.Size(35, 50);
            this.tileBtn.TabIndex = 0;
            this.tileBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tileBtn.UseAccentColor = false;
            this.tileBtn.UseVisualStyleBackColor = true;
            this.tileBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.tileBtn_Paint);
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
            this.Size = new System.Drawing.Size(35, 50);
            this.Load += new System.EventHandler(this.MahjongTileBtn_Load);
            this.EnabledChanged += new System.EventHandler(this.MahjongTileBtn_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialButton tileBtn;
        private System.Windows.Forms.ToolTip tileTip;
    }
}
