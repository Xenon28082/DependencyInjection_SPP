using System;

namespace DependencyInjectionContainer
{
    public class Service : IService
    {
        private readonly IProvider _provider;

        public Service(IProvider provider)
        {
            _provider = provider;
        }
        
        public void PrintSomething()
        {
            Console.WriteLine(_provider.RandomGuid);
        }
    }
}