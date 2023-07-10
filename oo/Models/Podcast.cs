class Podcast
{
    public string Host { get; }
    public string Name { get; }
    public int TotalEpisodes => episodes.Count;
    private List<Episode> episodes = new List<Episode>();

    public Podcast(string name, string host)
    {
        this.Name = name;
        this.Host = host;

    }

    public void AddEpisode(Episode episode)
    {
        this.episodes.Add(episode);
        System.Console.WriteLine($"Episódio, {episode.Title} adicionado com sucesso!");
    }

    public void ShowDetails()
    {   
        System.Console.WriteLine($"Podcast: {this.Name}");
        System.Console.WriteLine($"Host do Podcast: {this.Host}");
        System.Console.WriteLine($"Total de episódios: ");
        foreach (Episode episode in episodes.OrderBy(e => e.Order))
        {
            System.Console.WriteLine($"{episode.Title}");
        }
        System.Console.WriteLine($"Nº de eps: {this.TotalEpisodes}");
    } 
}