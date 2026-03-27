using System;

abstract class Product
{
    public string name;
    public double price;

    public Product(string n, double p)
    {
        name = n;
        price = p;
    }

    public abstract double GetPrice(int qty);
}