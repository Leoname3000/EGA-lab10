namespace EGA_lab10;
public class PopulationMutator {
    public List<Specimen> mutatePopulation(List<Specimen> children, IMutator mutator, double mutationProbability) {
        Random random = new Random();
        List<Specimen> mutants = new List<Specimen>();
        foreach (Specimen specimen in children) {
            Specimen mutant = mutator.mutate(specimen, mutationProbability);
            for (int i = 0; i < specimen.encoding.Count; i++) {
                if (specimen.encoding[i] != mutant.encoding[i]) {
                    mutants.Add(mutant);
                    break;
                }
            }
        }
        return mutants;
    }
}