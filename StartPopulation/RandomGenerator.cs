namespace EGA_lab10;
public class RandomGenerator : IGenerator {
    public Specimen generate() {
        Specimen specimen = new Specimen();
        Random random = new Random();
        for (int i = 0; i < Properties.items.Count; i++) {
            double randVal = random.NextDouble();
            if (randVal < 0.5)
                specimen.encoding[i] = true;
            else
                specimen.encoding[i] = false;
        }
        if (specimen.weight() > Properties.maxWeight)
            specimen = generate();
        return specimen;
    }
}