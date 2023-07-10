namespace OO.Heranca;

class Maltes : Dog
{
    public Maltes(string name, string color, bool hasTail) : base(name, color, hasTail)
    {
    }

    public void Teste()
    {
        
        // metodo que pode ser sobrescrito, porém esta sendo executado ainda o metodo da classe pai
        base.Execute();
    }
}