namespace OO.Models;
internal class Song
{
    private string name;
    private string artist;
    private int duration;
    private bool available;

    public Genre Genre { get; set; }

    // propriedaade sempre em PascalCase
    public int MyProperty 
    { 
        get 
        {
            return this.MyProperty;
        }
        set 
        {
            if (duration > 2)
            {
                this.MyProperty = value;
                // value é o valor que está sendo atribuído (sempre é padrão, o uso de value)	
            }
        }
    }

    // lambda expression
    public int MyProperty2 { get => this.MyProperty2; set => this.MyProperty2 = value; }

    public string GetName() 
    {
        return this.name;
    }

    public string GetArtist() 
    {
        return this.artist;
    }

    public int GetDuration()
    {
        return this.duration;
    }

    public bool GetAvailable()
    {
        return this.available;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetArtist(string artist)
    {
        this.artist = artist;
    }

    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void SetAvailable(bool available)
    {
        this.available = available;
    }

    public Song(string name, string artist, int duration, bool available, Genre genre)
    {
        this.name = name;
        this.artist = artist;
        this.duration = duration;
        this.available = available;
        this.Genre = genre;
    }

    public override string ToString()
    {
        return $"Name: {GetName()}, \nArtist: {GetArtist()}, \nDuration: {GetDuration()}, \nAvailable: {GetAvailable()}";
    }

    // lambda expression sum func
    public int Sum(int a, int b) => a + b;
}