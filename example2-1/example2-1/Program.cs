// See https://aka.ms/new-console-template for more information

using example2_1;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddSingleton<A>();
services.AddScoped<B>();
services.AddTransient<C>();

ServiceProvider serviceProvider = services.BuildServiceProvider();

A a1 = serviceProvider.GetService<A>();
A a2 = serviceProvider.GetService<A>();
B b1 = serviceProvider.GetService<B>();
B b2 = serviceProvider.GetService<B>();
C c1 = serviceProvider.GetService<C>();
C c2 = serviceProvider.GetService<C>();


// using (var scope = serviceProvider.CreateScope())
// {
//     A a3 = scope.ServiceProvider.GetService<A>();
//     A a4 = scope.ServiceProvider.GetService<A>();
//     B b3 = scope.ServiceProvider.GetService<B>();
//     B b4 = scope.ServiceProvider.GetService<B>();
//     C c3 = scope.ServiceProvider.GetService<C>();
//     C c4 = scope.ServiceProvider.GetService<C>();
// }