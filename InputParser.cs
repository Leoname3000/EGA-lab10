namespace EGA_lab10;
public static class InputParser {
    public static void parse(string inputPath) {
        
        string[] rawInput = File.ReadAllLines(inputPath);
        int thresholdWeight = Convert.ToInt32(rawInput[0]);
        Console.WriteLine($"Threshold weight = {thresholdWeight}");
        List<Item> items = new List<Item>();

        for (int i = 1; i < rawInput.Length; i++) {

            string[] rawStrings = rawInput[i].Split(" ");
            int weight = Convert.ToInt32(rawStrings[0]);
            int value = Convert.ToInt32(rawStrings[1]);
            
            Console.WriteLine($"Item {i - 1}: [ weight: {weight}, value: {value} ]");
            Item item = new Item(i, value, weight);
            items.Add(item);
        }

        Properties.initialize(items, thresholdWeight);
    }
}