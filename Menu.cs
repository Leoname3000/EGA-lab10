namespace EGA_lab10;
public static class Menu {
    const double crossoverProbability = 0.95;
    const double mutationProbability = 0.05;
    public static GeneticAlgorithm show() {

        IGenerator generator;
        ISplitter splitter = new RandomSplitter();
        ICrossover crossover;
        IMutator mutator;
        IModificator modificator = new GenotypeModificator();
        ISelector selector;

        Console.WriteLine($"\nChoose Generator: 0 - random, 1 - roulette");
        if (Console.ReadLine() == "0")
            generator = new RandomGenerator();
        else
            generator = new RouletteGenerator();
        
        Console.WriteLine($"Choose Crossover: 0 - single point, 1 - homogenous");
        if (Console.ReadLine() == "0")
            crossover = new SinglePointCrossover();
        else
            crossover = new HomogenousCrossover();

        Console.WriteLine($"Choose Mutator: 0 - genetic, 1 - chromosome");
        if (Console.ReadLine() == "0")
            mutator = new GeneticMutator();
        else
            mutator = new ChromosomeMutator();

        Console.WriteLine($"Choose Selector: 0 - proportional, 1 - ranking");
        if (Console.ReadLine() == "0")
            selector = new ProportionalSelector();
        else
            selector = new RankingSelector();

        Console.WriteLine($"Enter Overlap Ratio: ");
        double overlapRatio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Elite Strategy: 0 - ignore, 1 - use");
        bool useEliteStrategy;
        if (Console.ReadLine() == "0")
            useEliteStrategy = false;
        else
            useEliteStrategy = true;

        Console.WriteLine($"Enter Population Size: ");
        int populationSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter Number of Steps: ");
        int maxSteps = Convert.ToInt32(Console.ReadLine());

        GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm(generator, splitter, crossover, mutator, modificator, selector, 
                                                                 crossoverProbability, mutationProbability, 
                                                                 populationSize, maxSteps, 
                                                                 overlapRatio, useEliteStrategy);
        return geneticAlgorithm;
    }
}