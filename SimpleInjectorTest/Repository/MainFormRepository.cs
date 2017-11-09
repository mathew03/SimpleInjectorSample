using SimpleInjectorTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorTest.Repository
{
    public class MainFormRepository : IMainFormRepository
    {
        private ILoggerService _loggerService;

        public MainFormRepository(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void Create(string entity)
        {
            _loggerService.Log($"Creating {entity} - repository");
        }

        public void Get()
        {
            _loggerService.Log("Get entity - repository");
        }
    }
}
