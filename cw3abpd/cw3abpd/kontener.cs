namespace cw3abpd;

public abstract class kontener
{
    public double paylodeWeight;
    public double height;
    public double containerWeight;
    public double depth;
    public string serialnumber;
    public double maxCapacity;
    public static int primaryKey = 0;
    
    public kontener(double height, double containerWeight, double depth, double maxCapacity,char firstletter)
    {
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        serialnumber = "KON-"+firstletter+"-"+primaryKey;
        primaryKey++;
    }


    public virtual void unload()
    {
        paylodeWeight = 0;
    }

    public virtual void load(double mass)
    {
        if (mass > maxCapacity)
        {
            throw new Exception();
        }
        else
        {
            paylodeWeight += mass;
        }
    }
}