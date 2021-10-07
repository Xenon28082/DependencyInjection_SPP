using System;

namespace DependencyInjectionContainer.DependencyInjection
{
    public class ServiceInfo
    {
        public Type ServiceType { get; }
        
        public Type ImplementationType { get; }

        public object Implementation { get; internal set; }

        public ServiceLifetime Lifetime { get; }

        public ServiceInfo(object implementation, ServiceLifetime lifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }
        
        public ServiceInfo(Type serviceType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }
        
        public ServiceInfo(Type serviceType, Type implementationType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
            ImplementationType = implementationType;
        }
    }
}