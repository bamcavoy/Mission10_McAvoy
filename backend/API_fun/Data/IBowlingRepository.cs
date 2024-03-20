namespace API_fun.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }
    }
}
