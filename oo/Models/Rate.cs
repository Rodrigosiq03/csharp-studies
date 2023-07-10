namespace OO.Models;
internal class Rate
{
    public Rate(int nota)
    {
        this.Nota = nota;
    }

    public int Nota { get; }

    public static Rate Parse(string text)
    {
        int rate = int.Parse(text);
        return new Rate(rate);
    }
}