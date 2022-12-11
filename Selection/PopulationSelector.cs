namespace EGA_lab10;
public class PopulationSelector {
    public List<Specimen> selectPopulation(List<Specimen> parents, List<Specimen> replicants, ISelector selector, int populationSize, double overlapRatio, bool useEliteStrategy) {
        List<Specimen> population = new List<Specimen>();
        int selectQuantity = populationSize;
        if (useEliteStrategy == true) {
            Specimen bestSpecimen = new Specimen();
            int maxValue = -1;
            foreach (Specimen specimen in parents)
                if (specimen.value() > maxValue) {
                    maxValue = specimen.value();
                    bestSpecimen = specimen;
                }
            foreach (Specimen specimen in replicants)
                if (specimen.value() > maxValue) {
                    maxValue = specimen.value();
                    bestSpecimen = specimen;
                }
            population.Add(bestSpecimen);
            selectQuantity--;
        }
        population.AddRange(selector.select(parents, replicants, overlapRatio, selectQuantity));
        return population;
    }
}