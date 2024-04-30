namespace CS162_Chapter11_Problems.PlaylistApplication
{
    public partial class PlaylistDemo : Form
    {
        public PlaylistDemo()
        {
            InitializeComponent();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        PlaylistClass playlist = new PlaylistClass();

        private void addSong_Button_Click(object sender, EventArgs e)
        {
            string songTitle = song_TextBox.Text;
            string songArtist = artist_TextBox.Text;

            SongClass newSong = new SongClass(songTitle, songArtist);
            playlist.PlayList.Add(newSong);
            reloadPlaylist();
        }
        private void playlist_ListBox_Clicked(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            
            playlist.PlayList.RemoveAt(listBox.SelectedIndex);
            listBox.Items.Remove(listBox.SelectedItem);

        }
        private void reloadPlaylist()
        {
            playlist_ListBox.Items.Clear();
            playlist.PlayList.ForEach(song =>
            {
                playlist_ListBox.Items.Add($"{song.Title} by {song.Artist}");
            });
        }
    }
}
