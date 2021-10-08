using System.Collections.Generic;

namespace DependencyInjectionContainer.DependencyInjection
{
    public class DiCollection
    {
        private List<ServiceInfo> _servicesInfo = new List<ServiceInfo>();
        
        public void RegisterSingleton<TService, TImplementation>() where TImplementation : TService
        {
            _servicesInfo.Add(new ServiceInfo(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        public void RegisterTransient<TService, TImplementation>() where TImplementation : TService
        {
            _servicesInfo.Add(new ServiceInfo(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }

        public DiContainer GenerateContainer()
        {
            return new DiContainer(_servicesInfo);
        }
    }
}