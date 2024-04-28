using CS162_Chapter11_Problems.CarInstrumentSim;

namespace CS162_Chapter11_Problems.PlaylistApplication
{
    public partial class CarDemo : Form
    {
        public CarDemo()
        {
            InitializeComponent();
        }

        FuelGauageClass? fuelGauge = null;
        OdemterClass? odemeter = null;
        int MaxFuel = 15;

        public void onForm_Load(object sender, EventArgs e)
        {
            fuelGauge = new FuelGauageClass(MaxFuel);
            fuelBar_progressBar.Maximum = MaxFuel;
            fuelBar_progressBar.Value = 15;

            odemeter = new OdemterClass();

        }

        bool started = false;
        public void start(object sender, EventArgs e)
        {
            if (started) { return; }
            while (fuelGauge.getFuelLevels() > 0)
            {
                odemeter.updateMileage();
                odemeterLabel1.Text = (odemeter.getCurrentMileage()).ToString();
                fuelGauge.consumeFuel(1);
                fuelBar_progressBar.Value = (int)fuelGauge.getFuelLevels();
                fuelLabel1.Text = $"{(fuelGauge.getFuelLevels()).ToString("f2")}/{MaxFuel}";
                wait(0020);
            }
        }

        public void refuelButton_Click(object sender, EventArgs e)
        {
            fuelGauge.refuel();
        }


        /*
         * Wait one second in running program. (n.d.). Stack Overflow. 
         * Retrieved April 27, 2024, from https://stackoverflow.com/a/52906286‌
         */
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
