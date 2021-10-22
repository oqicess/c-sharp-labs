using Lab2;
class CarModel : IGiver
{
    public int id;
    public string name;
    public CarModel(int a, string b)
    {
        id = a;
        name = b;
    }
    public string GetInfo()
    {
        return ($"Кофемашина {id}, Название кофемашины: {name}\n");
    }
}