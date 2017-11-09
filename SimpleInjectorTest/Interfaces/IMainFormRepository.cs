using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorTest.Interfaces
{
    public interface IMainFormRepository
    {
        void Get();
        void Create(string entity);
    }
}
