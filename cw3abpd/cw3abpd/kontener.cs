namespace cw3abpd;

public class kontener
{
    public double paylodeWeight;
    public double height;
    public double containerWeight;
    public double depth;
    public string serialnumber;
    public double maxCapacity;
    public static int primaryKey = 0;
    
    public kontener(double paylodeWeight, double height, double containerWeight, double depth, double maxCapacity,char firstletter)
    {
        this.paylodeWeight = paylodeWeight;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        serialnumber = "KON-"+firstletter+"-"+primaryKey;
        primaryKey++;
    }


    public void unload()
    {
        paylodeWeight = 0;
    }

    public void load(double mass)
    {
        if (mass > maxCapacity)
        {
            throw new Exception();
        }
        else
        {
            paylodeWeight = paylodeWeight + mass;
        }
    }
}