namespace CS162_Chapter11_Problems.PlaylistApplication
{
    partial class PlaylistDemo
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
            groupBox1 = new GroupBox();
            song_TextBox = new TextBox();
            groupBox2 = new GroupBox();
            artist_TextBox = new TextBox();
            addSong_Button = new Button();
            playlist_ListBox = new ListBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            close_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(song_TextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 48);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Song Title:";
            // 
            // song_TextBox
            // 
            song_TextBox.Location = new Point(6, 19);
            song_TextBox.Name = "song_TextBox";
            song_TextBox.Size = new Size(188, 23);
            song_TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(artist_TextBox);
            groupBox2.Location = new Point(12, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 48);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter Artist:";
            // 
            // artist_TextBox
            // 
            artist_TextBox.Location = new Point(6, 19);
            artist_TextBox.Name = "artist_TextBox";
            artist_TextBox.Size = new Size(188, 23);
            artist_TextBox.TabIndex = 0;
            // 
            // addSong_Button
            // 
            addSong_Button.BackColor = Color.ForestGreen;
            addSong_Button.ForeColor = SystemColors.Control;
            addSong_Button.Location = new Point(18, 120);
            addSong_Button.Name = "addSong_Button";
            addSong_Button.Size = new Size(188, 23);
            addSong_Button.TabIndex = 2;
            addSong_Button.Text = "Add Song";
            addSong_Button.UseVisualStyleBackColor = false;
            addSong_Button.Click += addSong_Button_Click;
            // 
            // playlist_ListBox
            // 
            playlist_ListBox.FormattingEnabled = true;
            playlist_ListBox.ItemHeight = 15;
            playlist_ListBox.Location = new Point(6, 22);
            playlist_ListBox.Name = "playlist_ListBox";
            playlist_ListBox.Size = new Size(188, 199);
            playlist_ListBox.TabIndex = 3;
            playlist_ListBox.Click += playlist_ListBox_Clicked;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(playlist_ListBox);
            groupBox3.Location = new Point(12, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 228);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "PlayList";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(18, 389);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 5;
            label1.Text = "Tip: Click On A Song To Remove It";
            // 
            // close_Button
            // 
            close_Button.BackColor = Color.Tomato;
            close_Button.ForeColor = SystemColors.Control;
            close_Button.Location = new Point(198, 424);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(25, 23);
            close_Button.TabIndex = 6;
            close_Button.Text = "\U0001f6d1";
            close_Button.UseVisualStyleBackColor = false;
            close_Button.Click += close_Button_Click;
            // 
            // PlaylistDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 450);
            Controls.Add(close_Button);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(addSong_Button);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PlaylistDemo";
            Text = "PlaylistDemo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox song_TextBox;
        private GroupBox groupBox2;
        private TextBox artist_TextBox;
        private Button addSong_Button;
        private ListBox playlist_ListBox;
        private GroupBox groupBox3;
        private Label label1;
        private Button close_Button;
    }
}