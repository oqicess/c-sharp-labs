using Lab2;
abstract class Product : IGiver
{
    public int id;
    public int Cost;
    public int CostWater;
    public int CostSeed;
    public int Count;
    public Product(int a) { id = a; }
    public abstract string GetInfo();
}