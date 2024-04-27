namespace CS162_Chapter11_Problems.PlaylistApplication
{
    internal class SongClass
    {
        public string Title {get; init;}
        public string Artist {get; init;}

        public SongClass(string title, string artist){
            Title = title;
            Artist = artist;
        }
    }
}
