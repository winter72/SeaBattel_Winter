﻿using ServiceSeaBattle.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.ContextBattelSea;
using SeaBattelInterface.SeaInterface;

namespace ServiceSeaBattle.SeaService
{
    public class UserService : BaseSea,UserInterface
    {
        public UserService(ContextSea dbContext) : base(dbContext)
        {
        }
    }
}
