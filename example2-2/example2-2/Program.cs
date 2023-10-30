// See https://aka.ms/new-console-template for more information

using example2_2;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddScoped<A>();
services.AddScoped<B>();
services.AddScoped<C>();
services.AddScoped<D>();
services.AddScoped<E>();

ServiceProvider serviceProvider = services.BuildServiceProvider();

E e = serviceProvider.GetService<E>();