using ServiceSeaBattleLibrary.BaseService;
using System;
using System.Collections.Generic;
using System.Text;
using ModelLibrary.ContextBattelSea;

namespace ServiceSeaBattleLibrary.ServiceSeaBattle
{
    public class UserService : BaseSea
    {
        public UserService(ContextSea dbContext) : base(dbContext)
        {
        }
    }
}
