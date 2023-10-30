using Microsoft.Extensions.DependencyInjection;

namespace example2_3;

public static class RegisterMyClassesExt
{
    public static ServiceCollection RegisterMyClasses(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<A>();
        serviceCollection.AddScoped<B>();
        return serviceCollection;
    }
}