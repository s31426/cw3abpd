namespace cw3abpd;

public class kontenerowiec
{
    public string name;
    public double maxSpeed;
    public int maxCountConteiners;
    public double maxWeight;
    public List<kontener> kontenery = new List<kontener>();

    public kontenerowiec(string name, double maxSpeed, int maxCountConteiners, double maxWeight)
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
        this.maxCountConteiners = maxCountConteiners;
        this.maxWeight = maxWeight;
    }

    public void loadConteiners(kontener kontener)
    {
        if (kontenery.Count >= maxCountConteiners)
        {
            throw new Exception($"Too much conteiners for {name}");
        }

        double totalWeight = 0;
        for (int i = 0; i < kontenery.Count; i++)
        {
            totalWeight += kontenery[i].containerWeight + kontenery[i].paylodeWeight;
        }

        if (totalWeight > maxWeight)
        {
            throw new Exception($"Too much weight for {name}");
        }
        kontenery.Add(kontener);
    }
}