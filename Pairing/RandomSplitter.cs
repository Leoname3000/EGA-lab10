namespace EGA_lab10;
public class RandomSplitter : ISplitter {
    public List<Pair> splitIntoPairs(List<Specimen> population) {
        List<Specimen> specimenPool = new List<Specimen>(population);
        List<Pair> pairList = new List<Pair>();
        Random random = new Random();
        int steps = specimenPool.Count / 2;
        if (specimenPool.Count % 2 != 0) {
            Pair pair = new Pair();
            int parentIndex = random.Next(0, specimenPool.Count);
            pair.parentOne = specimenPool[parentIndex];
            pair.parentTwo = specimenPool[parentIndex];
            specimenPool.RemoveAt(parentIndex);
            pairList.Add(pair);
        }
        for (int i = 0; i < steps; i++) {
            Pair pair = new Pair();
            int parentOneIndex = random.Next(0, specimenPool.Count);
            pair.parentOne = specimenPool[parentOneIndex];
            specimenPool.RemoveAt(parentOneIndex);
            int parentTwoIndex = random.Next(0, specimenPool.Count);
            pair.parentTwo = specimenPool[parentTwoIndex];
            specimenPool.RemoveAt(parentTwoIndex);
            pairList.Add(pair);
        }
        return pairList;
    }
}