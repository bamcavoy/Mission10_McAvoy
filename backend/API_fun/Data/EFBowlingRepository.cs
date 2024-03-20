namespace API_fun.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingContext _bowlingContext;
        public EFBowlingRepository(BowlingContext tmp) { 
            _bowlingContext = tmp;
        }

        public IEnumerable<Bowlers> Bowlers => _bowlingContext.Bowlers;
        public IEnumerable<Teams> Teams => _bowlingContext.Teams;
    }
}
