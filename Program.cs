namespace EGA_lab10;
internal class Program
{
    private static void Main(string[] args)
    {
        const string inputPath = "/Users/leonidsulin/Documents/Development/Projects/CSharpProjects/EGA-lab10/knapsackInputLarge.txt";
        InputParser.parse(inputPath);

        GeneticAlgorithm geneticAlgorithm = Menu.show();
        geneticAlgorithm.run();
    }
}