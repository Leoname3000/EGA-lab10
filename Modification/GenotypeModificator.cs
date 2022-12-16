namespace EGA_lab10;
public class GenotypeModificator : IModificator {
    public Specimen modify(Specimen specimen) {
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
        return specimen;
    }
}