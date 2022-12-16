namespace EGA_lab10;
public class GeneticAlgorithm {

    public GeneticAlgorithm(IGenerator generator, ISplitter splitter, 
                            ICrossover crossover, IMutator mutator, 
                            IModificator modificator, ISelector selector,
                            double crossoverProbability, double mutationProbability,
                            int populationSize, int maxSteps,
                            double overlapRatio, bool useEliteStrategy
                            ) {

        this.generator = generator;
        this.splitter = splitter;
        this.crossover = crossover;
        this.mutator = mutator;
        this.modificator = modificator;
        this.selector = selector;

        this.crossoverProbability = crossoverProbability;
        this.mutationProbability = mutationProbability;
        this.populationSize = populationSize;
        this.maxSteps = maxSteps;
        this.overlapRatio = overlapRatio;
        this.useEliteStrategy = useEliteStrategy;
        
        populationGenerator = new PopulationGenerator();
        populationCrossover = new PopulationCrossover();
        populationMutator = new PopulationMutator();
        populationModificator = new PopulationModificator();
        populationSelector = new PopulationSelector();
    }

    public void run() {

        List<Specimen> parents = populationGenerator.generatePopulation(generator, populationSize);

        List<Pair> pairedParents = new List<Pair>();
        List<Specimen> children = new List<Specimen>();
        List<Specimen> mutants = new List<Specimen>();

        List<Specimen> allowedChildren = new List<Specimen>();
        List<Specimen> allowedMutants = new List<Specimen>();
        List<Specimen> replicants = new List<Specimen>();

        Specimen bestSpecimen = BestSpecimenFinder.find(parents);
        string reportString = Printer.reportString(0, bestSpecimen, parents);
        Console.WriteLine(reportString);

        for (int step = 0; step < maxSteps; step++) {

            pairedParents = splitter.splitIntoPairs(parents);
            children = populationCrossover.crossPopulation(pairedParents, crossover, crossoverProbability);
            mutants = populationMutator.mutatePopulation(children, mutator, mutationProbability);

            allowedChildren = populationModificator.modifyPopulation(children, modificator);
            allowedMutants = populationModificator.modifyPopulation(mutants, modificator);

            replicants = new List<Specimen>();
            replicants.AddRange(allowedChildren);
            replicants.AddRange(allowedMutants);
            parents = populationSelector.selectPopulation(parents, replicants, selector, populationSize, overlapRatio, useEliteStrategy);

            bestSpecimen = BestSpecimenFinder.find(parents);
            reportString = Printer.reportString(step + 1, bestSpecimen, parents);
            Console.WriteLine(reportString);
        }

        reportString = $"   ->  FINAL RESULT  {Printer.specimenString(bestSpecimen)}\n";
        Console.WriteLine(reportString);
    }

    IGenerator generator;
    ISplitter splitter;
    ICrossover crossover;
    IMutator mutator;
    IModificator modificator;
    ISelector selector;

    double crossoverProbability;
    double mutationProbability;
    int populationSize;
    int maxSteps;
    double overlapRatio;
    bool useEliteStrategy;

    PopulationGenerator populationGenerator;
    PopulationCrossover populationCrossover;
    PopulationMutator populationMutator;
    PopulationModificator populationModificator;
    PopulationSelector populationSelector;
}