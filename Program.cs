using System;
using System.Threading.Tasks;
using DependencyInjectionContainer.DependencyInjection;

namespace DependencyInjectionContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new DiCollection();

            services.RegisterTransient<IProvider, RandomGuidProvider>();
            services.RegisterSingleton<IService, Service>();
            
            
            var container = services.GenerateContainer();

            var service = container.GetService<IProvider>();
            var serviceFirst = container.GetService<IService>();
            var serviceSecond = container.GetService<IService>();
            
            
            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();
            Console.Write(service.RandomGuid);
        }
    }
}