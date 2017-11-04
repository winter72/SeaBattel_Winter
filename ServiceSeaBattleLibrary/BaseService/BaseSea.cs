using ModelLibrary.ContextBattelSea;

namespace ServiceSeaBattleLibrary.BaseService
{
    public class BaseSea
    {
        protected readonly ContextSea _dbContext;

        public BaseSea(ContextSea dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
