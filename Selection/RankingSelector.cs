namespace EGA_lab10;
public class RankingSelector : ISelector {
    public List<Specimen> select(List<Specimen> parents, List<Specimen> replicants, double overlapRatio, int selectQuantity) {
        Random random = new Random();
        List<Specimen> population = new List<Specimen>();
        int replicantQuantity = Convert.ToInt32(selectQuantity * overlapRatio);
        int parentQuantity = selectQuantity - replicantQuantity;
        for (int i = 0; i < parentQuantity; i++) {
            int parentIndex = random.Next(0, parentQuantity);
            population.Add(parents[parentIndex]);
        }
        for (int i = 0; i < replicantQuantity; i++) {

            List<Specimen> sortedReplicants = PopulationSorter.insertionSort(replicants);
            List<int> rankings = new List<int>();
            for (int j = 0; j < sortedReplicants.Count; j++)
                rankings.Add(j + 1);

            int localSum = 0;
            List<int> sums = new List<int>();
            for (int j = 0; j < rankings.Count; j++) {
                localSum += rankings[j];
                sums.Add(localSum);
            }
            double randVal = random.NextDouble() * localSum;
            int replicantIndex = -1;
            if (randVal == 0.0)
                replicantIndex = sortedReplicants.Count - 1;
            else
                for (int j = 0; j < sums.Count; j++)
                    if (randVal <= sums[j]) {
                        replicantIndex = j;
                        break;
                    }
            population.Add(sortedReplicants[replicantIndex]);
        }
        return population;
    }
}