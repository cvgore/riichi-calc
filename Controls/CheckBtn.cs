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

        public CheckBtn()
        {
            InitializeComponent();

            btn.Primary = Checked;
        }

        private void btn_Click(object? sender, System.EventArgs e)
        {
            Checked = btn.Primary = !Checked;
        }
    }
}
