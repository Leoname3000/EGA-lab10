namespace EGA_lab10;
public class HomogenousCrossover : ICrossover {
    public List<Specimen> cross(Pair pair) {
        List<Specimen> children = new List<Specimen>();
        Random random = new Random();
        for (int j = 0; j < 2; j++) {
            Specimen child = new Specimen();
            for (int i = 0; i < Properties.items.Count; i++) {
                double randVal = random.NextDouble();
                if (randVal >= 0.5) {
                    child.encoding[i] = pair.parentOne!.encoding[i];
                }
                else {
                    child.encoding[i] = pair.parentTwo!.encoding[i];
                }
            }
            children.Add(child);
        }
        return children;
    }
}