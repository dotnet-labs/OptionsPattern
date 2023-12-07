using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyLibrary;

var services = new ServiceCollection();
services.AddLogging(c => c.AddConsole());
services.AddMyService(options =>
{
    options.Option1 = "100 push-ups";
    options.Option2 = true;
    options.Option3 = 3;
});

using var serviceProvider = services.BuildServiceProvider();
var myService = serviceProvider.GetRequiredService<IMyService>();
myService.DoWork();
