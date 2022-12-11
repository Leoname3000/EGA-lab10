namespace EGA_lab10;
public class RouletteGenerator : IGenerator {
    public Specimen generate() {
        Specimen specimen = new Specimen();
        List<Item> itemPool = new List<Item>(Properties.items);
        while (itemPool.Count > 0) {
            List<int> sums = new List<int>();
            int localSum = 0;
            for (int i = 0; i < itemPool.Count; i++) {
                localSum += itemPool[i].value;
                sums.Add(localSum);
            }
            Random random = new Random();
            double randVal = random.NextDouble() * localSum;
            int itemIndex = -1;
            if (randVal == 0.0)
                itemIndex = itemPool.Count - 1;
            else
                for (int i = 0; i < sums.Count; i++)
                    if (randVal <= sums[i]) {
                        itemIndex = i;
                        break;
                    }
            if (specimen.weight() + itemPool[itemIndex].weight > Properties.maxWeight)
                break;
            specimen.encoding[itemIndex] = true;
            itemPool.RemoveAt(itemIndex);
        }
        return specimen;
    }
}