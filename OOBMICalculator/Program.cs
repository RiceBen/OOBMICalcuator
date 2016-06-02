using Autofac;
using OOBMICalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OOBMICalculator
{
    public class Program
    {
        static void Main(string[] args)
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
