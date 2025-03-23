namespace cw3abpd;

public class kontenerChlodniczy:kontener
{
    public string typProduktu;
    public double temp;

    public kontenerChlodniczy(string typProduktu, double temp, double height, double containerWeight, double depth,
        double maxCapacity)
        : base(height, containerWeight, depth, maxCapacity, 'C')
    {
        this.typProduktu = typProduktu;
        this.temp = temp;
    }

    public void setTemp(double temperature)
    {
        if (temperature < temp)
        {
            throw new Exception($"za niska temperatu {temperature}.");
        }
        this.temp = temperature;
    }

    public override void load(double mass)
    {
        base.load(mass);
    }
        
}