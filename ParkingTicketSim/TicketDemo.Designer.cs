namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    partial class TicketDemo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name_TextBox = new TextBox();
            badge_TextBox = new TextBox();
            login_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 0;
            label1.Text = "Parking Service System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(96, 133);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 1;
            label2.Text = "Badge Number";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(96, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new Point(96, 95);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(175, 23);
            name_TextBox.TabIndex = 3;
            // 
            // badge_TextBox
            // 
            badge_TextBox.Location = new Point(96, 154);
            badge_TextBox.Name = "badge_TextBox";
            badge_TextBox.Size = new Size(175, 23);
            badge_TextBox.TabIndex = 4;
            // 
            // login_Button
            // 
            login_Button.BackColor = Color.SteelBlue;
            login_Button.ForeColor = SystemColors.Control;
            login_Button.Location = new Point(96, 196);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(175, 33);
            login_Button.TabIndex = 5;
            login_Button.Text = "Login";
            login_Button.UseVisualStyleBackColor = false;
            login_Button.Click += login_Button_Click;
            // 
            // TicketDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 0, 85);
            ClientSize = new Size(365, 270);
            Controls.Add(login_Button);
            Controls.Add(badge_TextBox);
            Controls.Add(name_TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TicketDemo";
            Text = "TicketDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name_TextBox;
        private TextBox badge_TextBox;
        private Button login_Button;
    }
}