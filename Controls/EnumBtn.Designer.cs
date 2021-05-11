
namespace RiichiCalc.Controls
{
    partial class EnumBtn<T>
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
            this.toggleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggleBtn
            // 
            this.toggleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleBtn.Location = new System.Drawing.Point(0, 0);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(102, 77);
            this.toggleBtn.TabIndex = 0;
            this.toggleBtn.Text = "button1";
            this.toggleBtn.UseVisualStyleBackColor = true;
            this.toggleBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toggleBtn_MouseClick);
            // 
            // EnumBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.toggleBtn);
            this.Name = "EnumBtn";
            this.Size = new System.Drawing.Size(102, 77);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggleBtn;
    }
}
