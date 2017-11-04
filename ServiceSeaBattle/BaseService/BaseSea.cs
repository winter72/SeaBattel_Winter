using ModelLibrary.ContextBattelSea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSeaBattle.BaseService
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
