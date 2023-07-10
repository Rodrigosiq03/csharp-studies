namespace OO.Models;
internal class Band : IRate
{
    public Band(string name)
    {
        this.Name = name;
    }
    private List<Album> albums = new List<Album>();
    private List<Rate> rates = new List<Rate>();

    public double Average 
    {
        get
        {   
            if (rates.Count == 0) return 0;
            else return rates.Average(a => a.Nota);

        }
    }
    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowAlbums()
    {
        System.Console.WriteLine($"Discografia da banda {this.Name}");
        foreach (Album album in albums)
        {
            System.Console.WriteLine($"Album: {album.Name}");
        }
    }

    public void AddRate(Rate rate)
    {
        rates.Add(rate);
    }

}