using System;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjectorTest.Interfaces;
using SimpleInjectorTest.Helpers;
using SimpleInjectorTest.Presenter;
using SimpleInjectorTest.Repository;

namespace SimpleInjectorTest.View
{
    static class Program
    {
        public static Container DIC = new Container();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DIC.RegisterDependencies();
            IMainFormPresenter mainFormPresenter = DIC.GetInstance<IMainFormPresenter>();
            Application.Run(mainFormPresenter.GetView() as Form1);
        }

        private static void RegisterDependencies(this Container cont)
        {
            cont.Register<IMainForm, Form1>();
            cont.Register<ILoggerService, ConsoleLogger>();
            cont.Register<IMainFormPresenter, MainFormPresenter>();
            cont.Register<IMainFormRepository, MainFormRepository>();
        }
    }
}
