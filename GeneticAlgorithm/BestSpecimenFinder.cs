namespace EGA_lab10;
public static class BestSpecimenFinder {
    public static Specimen find(List<Specimen> population) {
        int maxVal = -1;
        Specimen bestSpecimen = new Specimen();
        foreach (Specimen specimen in population)
            if (specimen.value() > maxVal) {
                maxVal = specimen.value();
                bestSpecimen = specimen;
            }
        return bestSpecimen;
    }
}