using System.Reflection;

namespace Api;

public class ReflectionHelper
{
    public static IReadOnlyList<Assembly> GetAllAssemblies()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        return assemblies.ToList().AsReadOnly();
    }
}