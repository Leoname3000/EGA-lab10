namespace EGA_lab10;
public static class Printer {
    public static string specimenString(Specimen specimen) {
        string str = "";
        for (int i = 0; i < Properties.items.Count; i++)
            if (specimen.encoding[i] == true)
                str += "1";
            else
                str += "0";
        str += $" (v:{specimen.value(), 2},w:{specimen.weight(), 2})";
        return str;
    }
    public static string populationString(List<Specimen> population) {
        string str = "";
        for (int i = 0; i < population.Count; i++) {
            str += Printer.specimenString(population[i]);
            if (i < population.Count - 1)
                str += ", ";
        }
        str += "";
        return str;
    }
    public static string reportString(int step, Specimen bestSpecimen, List<Specimen> population) {
        string reportString = $"Step{step, 2} || Population: {populationString(population)} || Best {Printer.specimenString(bestSpecimen)}\n";
        return reportString;
    }
}