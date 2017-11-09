using SimpleInjectorTest.Helpers;
using SimpleInjectorTest.Interfaces;
using SimpleInjectorTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleInjectorTest.Tests.Repository
{
    public class MainFormRepositoryTests
    {
        private IMainFormRepository _repository;

        public MainFormRepositoryTests()
        {
            ILoggerService logger = new ConsoleLogger();
            _repository = new MainFormRepository(logger);
        }

        [Fact]
        public void CreateTest()
        {
            // Arrange
            var entity = "dino";
            // Act
            _repository.Create(entity);
        }
    }
}
