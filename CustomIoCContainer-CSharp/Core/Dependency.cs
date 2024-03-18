using CustomIoCContainer_CSharp.Enums;

namespace CustomIoCContainer_CSharp.Core;

public class Dependency
{
    public Dependency(Type serviceType, Type implementationType, DependencyLifetime lifetime)
    {
        ServiceType = serviceType ?? throw new ArgumentNullException(nameof(serviceType));
        ImplementationType = implementationType ?? throw new ArgumentNullException(nameof(implementationType));
        Lifetime = lifetime;
    }

    public Type ServiceType { get; } // Represents the type of service/interface for the dependency.
    public Type ImplementationType { get; } // Represents the type of the implementation for the dependency.
    public DependencyLifetime Lifetime { get; }
    public object Instance { get; private set; }
    public bool IsInstantiated { get; private set; } = false;

    public void SetInstance(object instance)
    {
        Instance = instance;
        IsInstantiated = true;
    }
}