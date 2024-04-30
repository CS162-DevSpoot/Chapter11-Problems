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
        List<ParkingTicketClass> parkingTickets = new List<ParkingTicketClass>();

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
                instanceCiteBtt.BackColor = Color.Goldenrod;
            }
        }

        private void examineButton_Clicked(object sender, EventArgs e)
        {
            Button examButton = (Button)sender;

            char[] nameToken = examButton.Name.ToCharArray();
            int id = int.Parse(nameToken.Last().ToString());

            ParkingMeterClass selectedMeter = meters[id];
            ParkedCarClass selectedCar = parkedCars[id];
            Button instanceCiteBtt = (Button)Controls.Find($"cite_Button{id}", true)[0];

            if(selectedCar.MinutesParked > selectedMeter.MinutesPaid)
            {
                MessageBox.Show($"This meter is expired, the car with plate {selectedCar.LicensePlate} may be cited.");

                instanceCiteBtt.Enabled = true;
                instanceCiteBtt.BackColor = Color.Gold;
            }
            else
            {
                MessageBox.Show("This meter is still active and valid. This car cannot be cited.");
            }
        }

        private void citeButton_Cliked(object sender, EventArgs e)
        {
            Button citeButton = (Button)sender;

            char[] nameToken = citeButton.Name.ToCharArray();
            int id = int.Parse(nameToken.Last().ToString());
            ParkingMeterClass selectedMeter = meters[id];
            ParkedCarClass selectedCar = parkedCars[id];

            double hoursOver = (selectedCar.MinutesParked - selectedMeter.MinutesPaid)/60;

            try
            {
                ParkingTicketClass newTicket = LEO.issueTicket(selectedCar, hoursOver);
                parkingTickets.Add(newTicket);
                MessageBox.Show($"Ticket has been issued to car. LP: {selectedCar.LicensePlate}, Make/Model/Color: {selectedCar.Make}/{selectedCar.Model}/{selectedCar.Color}. Fined: {newTicket.Fine.ToString("c")}");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
