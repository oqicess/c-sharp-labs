using Lab2;
class Water : Product
{
    public string name;
    public Water(int a, string b) : base(a) { id = a; name = b; }
    public override string GetInfo()
    {
        return ($"Вода {id}, Производитель: {name}\n");
    }
}