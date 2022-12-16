namespace EGA_lab10;
public interface IMutator {
    public Specimen mutate(Specimen specimen, double mutationProbability);
}