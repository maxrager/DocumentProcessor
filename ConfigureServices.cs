using System.Reflection;

namespace DocumentProcessor
{
    public static class ConfigureServices
    {
        public static void AddScopedDerivedClasses<TBaseType, TRegisterAs>(this IServiceCollection services, Assembly assembly)
        {
            var baseType = typeof(TBaseType);
            var registerAsType = typeof(TRegisterAs);

            var derivedTypes = assembly.GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract && baseType.IsAssignableFrom(x));

            foreach (var type in derivedTypes)
            {
                services.AddScoped(registerAsType, type);
            }
        }
    }
}
