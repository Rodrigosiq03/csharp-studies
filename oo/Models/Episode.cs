namespace OO.Models;
class Episode
{
    public int Order { get; }
    public int Duration { get;  }
    public string Summary => $"{this.Order}. {this.Title} ({this.Duration} min) - {string.Join(", ", guests)}";
    public string Title { get; }

    private List<string> guests = new List<string>();

    public Episode(int duration, int order, string title)
    {
        this.Duration = duration;
        this.Order = order;
        this.Title = title;
    }

    public void AddGuest(string guest)
    {
        this.guests.Add(guest);
    }
}