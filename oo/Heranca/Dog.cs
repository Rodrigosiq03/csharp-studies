namespace OO.Heranca;

class Dog : Animal
{
    public Dog(string name, string color, bool hasTail) : base(name, color, hasTail)
    {
    }

    // method that can be overrided
    public virtual void Execute()
    {
        System.Console.WriteLine("hello");
    }
}