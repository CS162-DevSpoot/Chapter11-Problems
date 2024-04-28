namespace CS162_Chapter11_Problems.PlaylistApplication
{
    partial class CarDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            startButton = new Button();
            refuelButton = new Button();
            groupBox1 = new GroupBox();
            odemeterLabel1 = new Label();
            fuelLabel1 = new Label();
            fuelBar_progressBar = new ProgressBar();
            closeButton = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(refuelButton);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(fuelLabel1);
            panel1.Controls.Add(fuelBar_progressBar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 140);
            panel1.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.BackColor = Color.SpringGreen;
            startButton.Location = new Point(232, 112);
            startButton.Name = "startButton";
            startButton.Size = new Size(27, 23);
            startButton.TabIndex = 5;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += start;
            // 
            // refuelButton
            // 
            refuelButton.BackColor = Color.DarkOrange;
            refuelButton.Location = new Point(91, 108);
            refuelButton.Name = "refuelButton";
            refuelButton.Size = new Size(75, 23);
            refuelButton.TabIndex = 4;
            refuelButton.Text = "Refuel";
            refuelButton.UseVisualStyleBackColor = false;
            refuelButton.Click += refuelButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(odemeterLabel1);
            groupBox1.Location = new Point(31, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 54);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Odemeter";
            // 
            // odemeterLabel1
            // 
            odemeterLabel1.BackColor = SystemColors.ControlLight;
            odemeterLabel1.Location = new Point(6, 19);
            odemeterLabel1.Name = "odemeterLabel1";
            odemeterLabel1.Size = new Size(188, 23);
            odemeterLabel1.TabIndex = 4;
            odemeterLabel1.Text = "000,000";
            odemeterLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fuelLabel1
            // 
            fuelLabel1.Location = new Point(78, 22);
            fuelLabel1.Name = "fuelLabel1";
            fuelLabel1.Size = new Size(100, 23);
            fuelLabel1.TabIndex = 2;
            fuelLabel1.Text = "15/15 Gal";
            fuelLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fuelBar_progressBar
            // 
            fuelBar_progressBar.Location = new Point(3, 3);
            fuelBar_progressBar.Maximum = 15;
            fuelBar_progressBar.Name = "fuelBar_progressBar";
            fuelBar_progressBar.RightToLeft = RightToLeft.No;
            fuelBar_progressBar.RightToLeftLayout = true;
            fuelBar_progressBar.Size = new Size(258, 16);
            fuelBar_progressBar.TabIndex = 1;
            fuelBar_progressBar.Value = 15;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Tomato;
            closeButton.Location = new Point(12, 158);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(264, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // CarDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 192);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            Name = "CarDemo";
            Text = "CarDemo";
            Load += onForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar fuelBar_progressBar;
        private Label fuelLabel1;
        private GroupBox groupBox1;
        private Label odemeterLabel1;
        private Button refuelButton;
        private Button closeButton;
        private Button startButton;
    }
}