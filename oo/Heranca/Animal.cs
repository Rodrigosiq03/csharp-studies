namespace OO.Heranca;

class Animal
{
    public string Name { get; }
    public string Color { get; }
    public bool HasTail { get; }

    public Animal(string name, string color, bool hasTail)
    {
        this.Name = name;
        this.Color = color;
        this.HasTail = hasTail;
    }

}