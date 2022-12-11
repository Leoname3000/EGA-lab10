namespace EGA_lab10;
public class PopulationMutator {
    public List<Specimen> mutatePopulation(List<Specimen> children, IMutator mutator, double mutationProbability) {
        Random random = new Random();
        List<Specimen> mutants = new List<Specimen>();
        foreach (Specimen specimen in children)
            if (random.NextDouble() < mutationProbability)
                mutants.Add(mutator.mutate(specimen));
        return mutants;
    }
}