using CustomIoCContainer_CSharp.Enums;

namespace CustomIoCContainer_CSharp.Core;

/// <summary>
/// This class is responsible for resolving dependencies and creating instances of requested services.
/// </summary>
public class DependencyResolver
{
    private readonly DependencyContainer _dependencyContainer;

    public DependencyResolver(DependencyContainer dependencyContainer)
    {
        _dependencyContainer = dependencyContainer ?? throw new ArgumentNullException(nameof(dependencyContainer));
    }

    public T GetService<T>() => (T)GetService(typeof(T));

    // Recursively resolves dependencies for the specified service type.
    public object GetService(Type type)
    {
        var dependency = _dependencyContainer.GetImplementationType(type); // pass-of type
        var constructor = dependency.ImplementationType.GetConstructors().Single();
        var parameters = constructor.GetParameters();

        if (parameters.Length > 0)
        {
            var parameterImplementations = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                parameterImplementations[i] = GetService(parameters[i].ParameterType);
            }

            return CreateInstance(dependency, t => Activator.CreateInstance(t, parameterImplementations));
        }

        return CreateInstance(dependency, t => Activator.CreateInstance(t));
    }

    // responsible for instantiating objects based on a given dependency and a factory function
    private object CreateInstance(Dependency dependency, Func<Type, object> factory)
    {
        if (dependency.IsInstantiated)
        {
            return dependency.Instance;
        }

        var instance = factory(dependency.ImplementationType);

        if (dependency.Lifetime == DependencyLifetime.Singleton)
        {
            dependency.SetInstance(instance);
        }

        return instance;
    }
}