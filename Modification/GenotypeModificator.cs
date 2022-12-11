namespace EGA_lab10;
public class GenotypeModificator : IModificator {
    const bool printReport = true;
    public Specimen modify(Specimen specimen) {
        string reportString = $"Modifying {Printer.specimenString(specimen)} -> ";
        while (specimen.weight() > Properties.maxWeight) {
            int minValue = int.MaxValue;
            int removableItemIndex = 0;
            for (int i = 0; i < Properties.items.Count; i++) {
                Item item = Properties.items[i];
                if (specimen.encoding[i] == true && item.value < minValue) {
                    minValue = item.value;
                    removableItemIndex = i;
                }
                specimen.encoding[removableItemIndex] = false;
            }
        }
        reportString += $"{Printer.specimenString(specimen)}";
        if (printReport == true)
            Console.WriteLine(reportString);
        return specimen;
    }
}