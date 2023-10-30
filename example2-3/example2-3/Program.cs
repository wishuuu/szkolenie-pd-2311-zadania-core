// See https://aka.ms/new-console-template for more information

using example2_3;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.RegisterMyClasses();

ServiceProvider serviceProvider = services.BuildServiceProvider();

serviceProvider.GetService<B>();
