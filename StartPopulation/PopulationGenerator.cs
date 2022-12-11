namespace EGA_lab10;
public class PopulationGenerator {
    public List<Specimen> generatePopulation(IGenerator generator, int populationSize) {
        List<Specimen> population = new List<Specimen>();
        for (int i = 0; i < populationSize; i++)
            population.Add(generator.generate());
        return population;
    }
}