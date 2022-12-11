namespace EGA_lab10;
public static class Properties {

    public static void initialize(List<Item> _items, int _maxWeight/*, int _populationSize, int _maxSteps*/) {
        items = _items;
        maxWeight = _maxWeight;
        // populationSize = _populationSize;
        // maxSteps = _maxSteps;
    }

    public static List<Item> items = new List<Item>();
    public static int maxWeight;
    // public static int populationSize;
    // public static int maxSteps;
}