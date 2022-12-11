namespace EGA_lab10;
public static class PopulationSorter {
    public static List<Specimen> insertionSort(List<Specimen> inputPopulation) {
        List<Specimen> sortedPopulation = new List<Specimen>(inputPopulation);
        for (int i = 1; i < sortedPopulation.Count; i++) {
            Specimen heldSpecimen = sortedPopulation[i];
            int j = i - 1;
            while (j >= 0 && sortedPopulation[j].value() > heldSpecimen.value()) {
                sortedPopulation[j + 1] = sortedPopulation[j];
                j--;
            }
            sortedPopulation[j + 1] = heldSpecimen;
        }
        return sortedPopulation;
    }
}