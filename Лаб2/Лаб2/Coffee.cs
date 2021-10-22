using Lab2;
class Coffee : Product
{
    public Coffee(int a, int b, int c, int d, int e) : base(a)
    {
        Cost = b;
        CostWater = c;
        CostSeed = d;
        Count = e;
    }
    public override string GetInfo()
    {
        return ($"Кофе {id}, Стоимость: {Cost}, Себестоимость воды: {CostWater}, Себестоимость зёрен: {CostSeed}, Кол-во: {Count}\n");
    }

}