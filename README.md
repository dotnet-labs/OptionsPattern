# Options Pattern in .NET Core

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

This solution demos one of the usages of the Options Pattern in .NET Core.

## [Medium Article: Options Patter in .NET Core](https://codeburst.io/options-pattern-in-net-core-a50285aeb18d)

When registering dependencies in the `ConfigureServices` method, you must have seen a pattern likes the following

```CSharp
services.AddDbContext<T>(options => options.**)

services.AddSwaggerGen(c => {
    c.SwaggerDoc(**);
})

```

This pattern is actually an extension method on top of `IServiceCollection`, and the naming convention of this type of extension method is `AddSomeService(this IServiceCollection services, Action<SomeOptions> action)`. The `action` is a Lambda function, which can be used to provide extra parameters to the service.

In this blog post, we will create a similar service that can be registered by calling the `services.AddMyService(Action<MyServiceOptions> action)` method. We will pass options to `MyService` so that this service can be more flexible with extra parameters.

## Intro to Options pattern in ASP.NET Core

[Microsoft Doc](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options)

The options pattern uses classes to represent groups of related settings. When configuration settings are isolated by scenario into separate classes, the app adheres to two important software engineering principles:

- The Interface Segregation Principle (ISP) or Encapsulation – Scenarios (classes) that depend on configuration settings depend only on the configuration settings that they use.
- Separation of Concerns – Settings for different parts of the app aren't dependent or coupled to one another.

## How to Create an Option Object in Tests

```csharp
Options.Create(new MyServiceOptions
                {
                    Option1 = "say hello",
                    Option2 = true
                }
            )
```

## License

Feel free to use the code in this repository as it is under MIT license.

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>
