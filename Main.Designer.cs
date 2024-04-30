namespace CS162_Chapter11_Problems
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthButton = new Button();
            carInstrumentButton = new Button();
            parkingSimButton = new Button();
            playlistButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // monthButton
            // 
            monthButton.Enabled = false;
            monthButton.Location = new Point(12, 12);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(122, 23);
            monthButton.TabIndex = 0;
            monthButton.Text = "Month Demo";
            monthButton.UseVisualStyleBackColor = true;
            // 
            // carInstrumentButton
            // 
            carInstrumentButton.Location = new Point(12, 41);
            carInstrumentButton.Name = "carInstrumentButton";
            carInstrumentButton.Size = new Size(122, 23);
            carInstrumentButton.TabIndex = 1;
            carInstrumentButton.Text = "Car Sim";
            carInstrumentButton.UseVisualStyleBackColor = true;
            carInstrumentButton.Click += carInstrumentButton_Click;
            // 
            // parkingSimButton
            // 
            parkingSimButton.Location = new Point(12, 70);
            parkingSimButton.Name = "parkingSimButton";
            parkingSimButton.Size = new Size(122, 23);
            parkingSimButton.TabIndex = 2;
            parkingSimButton.Text = "Parking Sim";
            parkingSimButton.UseVisualStyleBackColor = true;
            parkingSimButton.Click += parkingSimButton_Click;
            // 
            // playlistButton
            // 
            playlistButton.Location = new Point(12, 99);
            playlistButton.Name = "playlistButton";
            playlistButton.Size = new Size(122, 23);
            playlistButton.TabIndex = 3;
            playlistButton.Text = "Playlist Demo";
            playlistButton.UseVisualStyleBackColor = true;
            playlistButton.Click += playlistButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(12, 128);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 159);
            Controls.Add(exitButton);
            Controls.Add(playlistButton);
            Controls.Add(parkingSimButton);
            Controls.Add(carInstrumentButton);
            Controls.Add(monthButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button monthButton;
        private Button carInstrumentButton;
        private Button parkingSimButton;
        private Button playlistButton;
        private Button exitButton;
    }
}
