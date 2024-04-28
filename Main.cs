using CS162_Chapter11_Problems.PlaylistApplication;

namespace CS162_Chapter11_Problems
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void carInstrumentButton_Click(object sender, EventArgs e)
        {
            Form carDemo = new CarDemo();
            carDemo.ShowDialog();
        }
    }
}
