namespace cw3abpd;

public class kontenerNaplyny:kontener,IHazardNotifier

{
    public bool ladunekNiebezpieczy;
    public kontenerNaplyny( double height, double containerWeight, double depth, double maxCapacity,bool ladunekNiebezpieczy)
        :base(height, containerWeight,  depth,  maxCapacity, 'L')
    {
        this.ladunekNiebezpieczy = ladunekNiebezpieczy;
    }
    

    public void SendHazardNotification(string msg)
    {
        Console.WriteLine($"kontenerNaplyny : {serialnumber} {msg}");
    }

    public override void load(double mass)
    {
        double allowedCapacity = ladunekNiebezpieczy  ? maxCapacity*0.5 : maxCapacity*0.9;
        if (paylodeWeight + mass > allowedCapacity)
        {
            string msg = $"zaaa duzo";
            SendHazardNotification(msg);
            throw new Exception(msg);
        }
    }
}