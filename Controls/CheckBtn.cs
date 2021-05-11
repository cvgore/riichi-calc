using System.Windows.Forms;

namespace RiichiCalc.Controls
{
    public partial class CheckBtn : UserControl
    {
        public bool Checked
        {
            get => stateIndicatorCheckbox.Checked; 
            set => stateIndicatorCheckbox.Checked = value;
        }

        public string Content
        {
            get => btn.Text;
            set => btn.Text = value;
        }

        public CheckBtn()
        {
            InitializeComponent();
        }
    }
}
