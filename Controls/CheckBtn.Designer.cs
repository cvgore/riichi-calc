
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
            this.btn = new System.Windows.Forms.Button();
            this.stateIndicatorCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Margin = new System.Windows.Forms.Padding(0);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(75, 25);
            this.btn.TabIndex = 0;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // stateIndicatorCheckbox
            // 
            this.stateIndicatorCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stateIndicatorCheckbox.AutoSize = true;
            this.stateIndicatorCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.stateIndicatorCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stateIndicatorCheckbox.Enabled = false;
            this.stateIndicatorCheckbox.Location = new System.Drawing.Point(6, 6);
            this.stateIndicatorCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.stateIndicatorCheckbox.Name = "stateIndicatorCheckbox";
            this.stateIndicatorCheckbox.Size = new System.Drawing.Size(15, 14);
            this.stateIndicatorCheckbox.TabIndex = 1;
            this.stateIndicatorCheckbox.TabStop = false;
            this.stateIndicatorCheckbox.UseVisualStyleBackColor = false;
            // 
            // CheckBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.stateIndicatorCheckbox);
            this.Controls.Add(this.btn);
            this.MinimumSize = new System.Drawing.Size(75, 25);
            this.Name = "CheckBtn";
            this.Size = new System.Drawing.Size(75, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.CheckBox stateIndicatorCheckbox;
    }
}
