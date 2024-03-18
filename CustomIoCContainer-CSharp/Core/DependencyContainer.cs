using CustomIoCContainer_CSharp.Enums;

namespace CustomIoCContainer_CSharp.Core;

/// <summary>
/// This class is responsible for managing dependencies.
/// </summary>
public class DependencyContainer
{
    private readonly List<Dependency> _dependencies;

    public DependencyContainer()
    {
        _dependencies = new List<Dependency>();
    }

    public void AddSingleton<TServiceAndImplementationType>() 
        => AddDependency<TServiceAndImplementationType>(DependencyLifetime.Singleton);

    public void AddSingleton<TService, TImplementation>()
        => AddDependency<TService, TImplementation>(DependencyLifetime.Singleton);

    public void AddTransient<TServiceAndImplementationType>()
        => AddDependency<TServiceAndImplementationType>(DependencyLifetime.Transient);

    public void AddTransient<TService, TImplementation>()
        => AddDependency<TService, TImplementation>(DependencyLifetime.Transient);

    public Dependency GetImplementationType(Type serviceType)
    {
        return _dependencies.First(x => x.ServiceType.Name == serviceType.Name);
    }

    private void AddDependency<TServiceAndImplementationType>(DependencyLifetime lifetime)
        => _dependencies.Add(new Dependency(typeof(TServiceAndImplementationType), typeof(TServiceAndImplementationType), lifetime));

    private void AddDependency<TService, TImplementation>(DependencyLifetime lifetime) 
        => _dependencies.Add(new Dependency(typeof(TService), typeof(TImplementation), lifetime));
}