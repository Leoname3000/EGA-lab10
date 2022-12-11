namespace EGA_lab10;
public class PopulationCrossover {
    public List<Specimen> crossPopulation(List<Pair> pairedParents, ICrossover crossover, double crossoverProbability) {
        Random random = new Random();
        List<Specimen> children = new List<Specimen>();
        foreach (Pair pair in pairedParents)
            if (random.NextDouble() < crossoverProbability)
                children.AddRange(crossover.cross(pair));
            else {
                // Возможно, отправить родителей напрямую в мн-во детей
                // children.Add(pair.parentOne!);
                // children.Add(pair.parentTwo!);
            }
        return children;
    }
}