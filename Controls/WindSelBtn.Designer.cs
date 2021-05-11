
namespace RiichiCalc.Controls
{
    partial class WindSelBtn
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
            this.togglerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // togglerBtn
            // 
            this.togglerBtn.AutoSize = true;
            this.togglerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.togglerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.togglerBtn.Location = new System.Drawing.Point(0, 0);
            this.togglerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.togglerBtn.Name = "togglerBtn";
            this.togglerBtn.Size = new System.Drawing.Size(88, 35);
            this.togglerBtn.TabIndex = 0;
            this.togglerBtn.UseVisualStyleBackColor = true;
            this.togglerBtn.Click += new System.EventHandler(this.togglerBtn_Click);
            this.togglerBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.togglerBtn_Paint);
            // 
            // WindSelBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.togglerBtn);
            this.Name = "WindSelBtn";
            this.Size = new System.Drawing.Size(88, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button togglerBtn;
    }
}
