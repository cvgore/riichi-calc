using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace RiichiCalc.Controls
{
    public partial class CheckBtn : UserControl
    {
        public bool Checked { get; set; }

        public string Content
        {
            get => btn.Text;
            set => btn.Text = value;
        }

        public event EventHandler CheckedChanged;

        public CheckBtn()
        {
            InitializeComponent();

            btn.UseAccentColor = Checked;
        }

        private void btn_Click(object? sender, System.EventArgs e)
        {
            Checked = btn.UseAccentColor = !Checked;
            CheckedChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}