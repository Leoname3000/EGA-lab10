namespace EGA_lab10;
public static class Printer {
    private const int specimensPerRow = 6;
    private const string spacer = "    ";
    private const int statLength = 3;
    public static string specimenString(Specimen specimen) {
        string str = "";
        for (int i = 0; i < Properties.items.Count; i++)
            if (specimen.encoding[i] == true)
                str += "1";
            else
                str += "0";
        str += $" (v:{specimen.value(), statLength},w:{specimen.weight(), statLength})";
        return str;
    }
    public static string populationString(List<Specimen> population) {
        string str = "";
        for (int i = 0; i < population.Count; i++) {
            str += Printer.specimenString(population[i]);
            if (i < population.Count - 1)
                str += ", ";
            if ((i + 1) % specimensPerRow == 0 && (i + 1) != population.Count)
                str += $"\n{spacer}";
        }
        str += "";
        return str;
    }
    public static string reportString(int step, Specimen bestSpecimen, List<Specimen> population) {
        string reportString = $"Step {step, 2}: \n{spacer}{populationString(population)} \n\n{spacer}Best: {Printer.specimenString(bestSpecimen)}\n";
        return reportString;
    }
}