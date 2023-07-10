namespace OO.Models;
class Album
{
    public Album(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
    private List<Song> songs = new List<Song>();

    public int TotalDuration => songs.Sum(m => m.GetDuration());

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public string GetAlbum()
    {
        string songInAlbum = "";
        if (songs.Count != 0)
        {
                foreach(Song song in songs)
            {
                songInAlbum =  "Name: " + song.GetName() + "\nArtist: " + song.GetArtist() + "\nDuration: " + song.GetDuration() + "\nAvailable: " + song.GetAvailable() + "\n";
            }
        } else 
        {
            return "No songs in this album";
        }
        return songInAlbum + $"\nTo listen the whole album you are going to spend ${this.TotalDuration}";
    }
}