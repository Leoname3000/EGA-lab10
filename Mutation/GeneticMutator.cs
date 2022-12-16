namespace EGA_lab10;
public class GeneticMutator : IMutator {
    public Specimen mutate(Specimen specimen, double mutationProbability) {
        Random random = new Random();
        int mutationIndex = random.Next(0, specimen.encoding.Count);
        if (random.NextDouble() < mutationProbability)
            specimen.encoding[mutationIndex] = !specimen.encoding[mutationIndex];
        return specimen;
    }
}