using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OOBMICalculator
{
    /// <summary>
    /// Autofac 依賴注入設定
    /// </summary>
    public static class AutofacConfiger
    {
        /// <summary>
        /// 取得依賴注入後的容器
        /// </summary>
        /// <returns>容器</returns>
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            var service = Assembly.Load("OOBMICalculator");

            builder.RegisterAssemblyTypes(service)
                .AsImplementedInterfaces()
                .SingleInstance();

            return builder.Build();
        }
    }
}
