namespace EGA_lab10;
public class SinglePointCrossover : ICrossover {
    public List<Specimen> cross(Pair pair) {
        Random random = new Random();
        int splitPoint = random.Next(1, Properties.items.Count);
        List<Specimen> children = new List<Specimen>();
        Specimen childOne = new Specimen();
        Specimen childTwo = new Specimen();
        for (int i = 0; i < Properties.items.Count; i++)
            if (i < splitPoint) {
                childOne.encoding[i] = pair.parentOne!.encoding[i];
                childTwo.encoding[i] = pair.parentTwo!.encoding[i];
            }
            else {
                childOne.encoding[i] = pair.parentTwo!.encoding[i];
                childTwo.encoding[i] = pair.parentOne!.encoding[i];
            }
        children.Add(childOne);
        children.Add(childTwo);
        return children;
    }
}