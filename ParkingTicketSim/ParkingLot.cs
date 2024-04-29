namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    public partial class ParkingLot : Form
    {
        PoliceOfficerClass? LEO = null;
        public ParkingLot(PoliceOfficerClass leo)
        {
            LEO = leo;
            InitializeComponent();
        }

        ParkedCarClass[] parkedCars = new ParkedCarClass[6];
        ParkingMeterClass[] meters = new ParkingMeterClass[6];

        private void onLoad_event(object sender, EventArgs e)
        {
            loadParkingLot();
        }

        private void loadParkingLot()
        {
            for (int i = 0; i < 6; i++)
            {
                Random rand = new Random();
                int minsParked = rand.Next(0, 300);
                int minsPaid = rand.Next(15, 300);

                string LP = $"{i + 2}A{i}-B{i + 5}C";

                ParkedCarClass newCar = new ParkedCarClass("Chevy", "HHR", "Silver", LP, minsParked);
                ParkingMeterClass newMeter = new ParkingMeterClass(minsPaid);

                parkedCars[i] = newCar;
                meters[i] = newMeter; 

                Label instanceStatus = (Label)Controls.Find($"status_Label{i}", true)[0];
                Label instanceOT = (Label)Controls.Find($"timeOver_Label{i}", true)[0];
                Label instancePlate = (Label)Controls.Find($"plate_Label{i}", true)[0];

                instancePlate.Text = LP;

                if (minsPaid > minsParked)
                {
                    instanceStatus.BackColor = Color.DarkGreen;
                    instanceStatus.Text = "VALID";

                    instanceOT.Text = $"-{minsPaid - minsParked}";
                }
                else
                {
                    instanceStatus.BackColor = Color.Red;
                    instanceStatus.Text = "EXPERIED";

                    instanceOT.Text = $"+{minsParked - minsPaid}";
                }

                Button instanceCiteBtt = (Button)Controls.Find($"cite_Button{i}", true)[0];
                instanceCiteBtt.Enabled = false;
            }
        }

        private void examineButton_Clicked(object sender, EventArgs e)
        {
            Button examButton = (Button)sender;

            char[] nameToken = examButton.Name.ToCharArray();
            int id = int.Parse(nameToken.Last().ToString());

            MessageBox.Show($"Attempted to examine Meter {id}.");
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            loadParkingLot();
        }
    }
}
