using System;

class Liquid
{
    private string name;
    private double density;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Density
    {
        get { return density; }
        set { density = value; }
    }

    public Liquid(string name, double density)
    {
        this.name = name;
        this.density = density;
    }

    public Liquid(Liquid other)
    {
        name = other.name;
        density = other.density;
    }

    public override string ToString()
    {
        return $"Liquid: {name}, Density: {density}";
    }
}

class Alcohol
{
    private Liquid liquid;
    private double strength;

    public Liquid Liquid
    {
        get { return liquid; }
        set { liquid = value; }
    }

    public double Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public Alcohol(string name, double density, double strength)
    {
        liquid = new Liquid(name, density);
        this.strength = strength;
    }

    public Alcohol(Alcohol other)
    {
        liquid = new Liquid(other.liquid);
        strength = other.strength;
    }

    public override string ToString()
    {
        return $"Alcohol: {liquid}, Strength: {strength}%";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Liquid water = new Liquid("Water", 1.0);
        Alcohol vodka = new Alcohol("Vodka", 0.9, 40.0);

        Console.WriteLine(water);
        Console.WriteLine(vodka);

        Console.WriteLine("Changing properties...");

        water.Name = "Distilled Water";
        vodka.Strength = 50.0;

        Console.WriteLine(water);
        Console.WriteLine(vodka);

        Console.WriteLine("Copying objects...");

        Liquid waterCopy = new Liquid(water);
        Alcohol vodkaCopy = new Alcohol(vodka);

        Console.WriteLine(waterCopy);
        Console.WriteLine(vodkaCopy);
    }
}

