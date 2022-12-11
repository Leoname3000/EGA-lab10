namespace EGA_lab10;
public class GeneticMutator : IMutator {
    public Specimen mutate(Specimen specimen) {
        Random random = new Random();
        int mutationIndex = random.Next(0, specimen.encoding.Count);
        specimen.encoding[mutationIndex] = !specimen.encoding[mutationIndex];
        return specimen;
    }
}