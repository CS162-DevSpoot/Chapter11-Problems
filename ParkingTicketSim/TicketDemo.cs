namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    public partial class TicketDemo : Form
    {
        public TicketDemo()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PoliceOfficerClass leo = new PoliceOfficerClass(int.Parse(badge_TextBox.Text), name_TextBox.Text);
                Form parkingLot = new ParkingLot(leo);
                parkingLot.Show();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
