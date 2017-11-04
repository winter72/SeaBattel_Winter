using ModelLibrary.ContextBattelSea;
using SeaBattelInterface.SeaInterface;
using ServiceSeaBattle.SeaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSeaBattle.UnitOfWork
{
    public class UnitOfWorks
    {
        private static UnitOfWorks _instance;
        private ContextSea _dbContext;
        private UserInterface _userService;
        private UserAccountInterface _useraccountService;
        private BattelFieldInterface _battelfieldService;
        public static UnitOfWorks Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UnitOfWorks();
                return _instance;
            }
        }
        public ContextSea DbContext
        {
            get
            {
                if (_dbContext == null)
                    _dbContext = new ContextSea();
                return _dbContext;
            }
        }
        public UserInterface UserService
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService(DbContext);
                return _userService;
            }
        }
        public UserAccountInterface AccountService
        {
            get
            {
                if (_useraccountService == null)
                    _useraccountService = new AccountService(DbContext);
                return _useraccountService;
            }
        }
        public BattelFieldInterface BattelFieldService
        {
            get
            {
                if (_battelfieldService == null)
                    _battelfieldService = new BattelFieldService(DbContext);
                return _battelfieldService;
            }
        }
    }
}
