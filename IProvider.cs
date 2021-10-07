using System;

namespace DependencyInjectionContainer
{

    public interface IProvider
    {
        Guid RandomGuid { get; }
    }

    public class RandomGuidProvider : IProvider
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }

}