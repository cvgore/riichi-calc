
namespace RiichiCalc.Controls
{
    partial class CheckBtn
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
            this.btn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn.Depth = 0;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.HighEmphasis = true;
            this.btn.Icon = null;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Margin = new System.Windows.Forms.Padding(0);
            this.btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(87, 36);
            this.btn.TabIndex = 0;
            this.btn.Text = "button1";
            this.btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn.UseAccentColor = false;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // CheckBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btn);
            this.MinimumSize = new System.Drawing.Size(75, 25);
            this.Name = "CheckBtn";
            this.Size = new System.Drawing.Size(87, 36);
            this.Load += new System.EventHandler(this.CheckBtn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn;
    }
}
