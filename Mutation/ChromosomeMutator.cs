namespace EGA_lab10;
public class ChromosomeMutator : IMutator {
    public Specimen mutate(Specimen specimen) {
        for (int i = 0; i < specimen.encoding.Count; i++)
            specimen.encoding[i] = !specimen.encoding[i];
        return specimen;
    }
}