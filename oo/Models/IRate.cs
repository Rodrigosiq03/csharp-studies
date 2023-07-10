namespace OO.Models;

internal interface IRate
{
    void AddRate(Rate rate);
    double Average { get; }
}