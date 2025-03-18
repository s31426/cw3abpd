namespace cw3abpd;

public class kontenerNaplyny:kontener,IHazardNotifier

{
    public bool ladunekNiebezpieczy;
    public kontenerNaplyny(double paylodeWeight, double height, double containerWeight, double depth, double maxCapacity,char firstLetter,bool ladunekNiebezpieczy)
        :base(paylodeWeight,height, containerWeight,  depth,  maxCapacity, 'L')
    {
        this.ladunekNiebezpieczy = ladunekNiebezpieczy;
    }


    public void SendHazardNotification(string msg)
    {
        Console.WriteLine($"kontenerNaplyny : {serialnumber} {msg}");
    }
    
}