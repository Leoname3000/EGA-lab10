namespace EGA_lab10;
public class ChromosomeMutator : IMutator {
    public Specimen mutate(Specimen specimen, double mutationProbability) {
        Random random = new Random();
        for (int i = 0; i < specimen.encoding.Count; i++)
            if (random.NextDouble() < mutationProbability)
                specimen.encoding[i] = !specimen.encoding[i];
        return specimen;
    }
}