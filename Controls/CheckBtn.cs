using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace RiichiCalc.Controls
{
    public partial class CheckBtn : UserControl
    {
        private bool _checked;
        public bool Checked { get => _checked; set => SetChecked(value); }

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
        private void SetChecked(bool value)
        {
            _checked = value;
            btn.UseAccentColor = value;
        }

        private void btn_Click(object? sender, System.EventArgs e)
        {
            Checked = !Checked;

            CheckedChanged?.Invoke(null, EventArgs.Empty);
        }

        private void CheckBtn_Load(object sender, EventArgs e)
        {
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}