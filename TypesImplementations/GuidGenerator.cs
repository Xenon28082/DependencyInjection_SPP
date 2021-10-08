using System;

namespace DependencyInjectionContainer
{
    public class GuidGenerator
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}