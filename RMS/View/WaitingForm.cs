using System.Drawing;
using System.Windows.Forms;

namespace RMS.View
{
    public partial class WaitingForm : Form
    {
        public WaitingForm()
        {
            InitializeComponent();
            BackColor = Color.LimeGreen;
            TransparencyKey = Color.LimeGreen;
            radWaitingBar1.StartWaiting();
            /*SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;*/

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        public void Stop()
        {
            radWaitingBar1.StopWaiting();
            Close();
        }
    }
}
