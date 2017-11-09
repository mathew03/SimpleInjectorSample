using SimpleInjectorTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorTest.Presenter
{
    public class MainFormPresenter : IMainFormPresenter
    {
        private IMainForm _view;
        private IMainFormRepository _repository;
        private ILoggerService _loggerService;

        public MainFormPresenter(IMainForm view, IMainFormRepository repository, ILoggerService loggerService)
        {
            _view = view;
            _repository = repository;
            _loggerService = loggerService;


            _view.ButtonClicked += ActSomething;
        }

        private void ActSomething(object sender, EventArgs e)
        {
            _repository.Create("something");
            _loggerService.Log("After repo create - logger");

            _repository.Get();
            _loggerService.Log("After repo get - logger");
        }

        public IMainForm GetView()
        {
            return _view;
        }
    }
}
