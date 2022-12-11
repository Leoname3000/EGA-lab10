namespace EGA_lab10;
public class Specimen {

    public Specimen() {
        this.encoding = new List<bool>();
        for (int i = 0; i < Properties.items.Count; i++) {
            encoding.Add(false);
        }
    }

    public Specimen(List<bool> encoding) {
        this.encoding = encoding;
    }

    public List<bool> encoding;
    
    public int value() {
        int value = 0;
        for (int i = 0; i < Properties.items.Count; i++)
            if (encoding[i] == true)
                value += Properties.items[i].value;
        return value;
    }

    public int weight() {
        int weight = 0;
        for (int i = 0; i < Properties.items.Count; i++)
            if (encoding[i] == true)
                weight += Properties.items[i].weight;
        return weight;
    }
}