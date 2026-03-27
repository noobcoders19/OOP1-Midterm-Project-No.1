class Electronics : Product
{
    private double fee = 50;

    public Electronics(string n, double p) : base(n, p) { }

    public override double GetPrice(int qty)
    {
        return (price + fee) * qty;
    }
}
