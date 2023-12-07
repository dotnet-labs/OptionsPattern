using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MyLibrary;

public interface IMyService
{
    void DoWork();
}

public class MyService(ILogger<MyService> logger, IOptions<MyServiceOptions> options) : IMyService
{
    private readonly string _option1 = options.Value.Option1;
    private readonly bool _option2 = options.Value.Option2;
    private readonly int _option3 = options.Value.Option3;

    public void DoWork()
    {
        logger.LogInformation("Begin workouts...");
        logger.LogInformation("{o}", _option1);
        if (_option2)
        {
            logger.LogInformation("100 sit-ups");
        }
        logger.LogInformation("Repeat {o} times.", _option3);
        logger.LogInformation("Done.");
    }
}