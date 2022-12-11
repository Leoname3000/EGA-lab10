namespace EGA_lab10;
public interface ISelector {
    public List<Specimen> select(List<Specimen> parents, List<Specimen> replicants, double overlapRatio, int selectQuantity);
}