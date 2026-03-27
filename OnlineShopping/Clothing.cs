class Clothing : Product
{
    public Clothing(string n, double p) : base(n, p) { }

    public override double GetPrice(int qty)
    {
        return price * qty;
    }
}