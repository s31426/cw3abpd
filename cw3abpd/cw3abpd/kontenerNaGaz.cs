namespace cw3abpd;

public class kontenerNaGaz:kontener , IHazardNotifier
{
    public double pressure;

    public kontenerNaGaz(double height, double containerWeight, double depth, double maxCapacity, double pressure) :
        base(height, containerWeight, depth, maxCapacity, 'G')
    {
        this.pressure = pressure;
    }

    public override void unload()
    {
        paylodeWeight *= 0.05;
    }

    public override void load(double mass)
    {
        if (mass + paylodeWeight > maxCapacity)
        {
            string msg = $"too much";
            SendHazardNotification(msg);
            throw new Exception(msg);
        }
    }
    public void SendHazardNotification(string msg)
    {
        Console.WriteLine($"kontenerNaplyny : {serialnumber} {msg}");
    }
}