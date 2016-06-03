using Autofac;
using OOBMICalculator.Services.Interfaces;

namespace OOBMICalculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var container = AutofacConfiger.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }
        }
    }
}