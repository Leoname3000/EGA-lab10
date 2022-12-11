namespace EGA_lab10;
public class PopulationModificator {
    public List<Specimen> modifyPopulation(List<Specimen> population, IModificator modificator) {
        List<Specimen> acceptablePopulation = new List<Specimen>(); 
        foreach (Specimen specimen in population)
            if (specimen.weight() > Properties.maxWeight)
                acceptablePopulation.Add(modificator.modify(specimen));
            else
                acceptablePopulation.Add(specimen);
        return acceptablePopulation;
    }
}