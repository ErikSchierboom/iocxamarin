# Inversion of Control on Xamarin.iOS and Xamarin.Android

Two demo applications that show how to use inversion of control (IoC) container in a Xamarin.iOS or Xamarin.Android application. Most full blown IoC containers cannot be used on Xamarin.iOS and Xamarin.Android. There is one IoC container that is designed to be small, lightweight and easy to setup that _does_ work on Xamarin.iOS and Xamarin.Android: 
[TinyIoC](https://github.com/grumpydev/TinyIoC). This IoC container is nothing more than a single file that you can include in your project.

## Implementation

After including the [TinyIoc.cs](https://github.com/grumpydev/TinyIoC/blob/master/src/TinyIoC/TinyIoC.cs) file in your project, you are ready to go. Setting up TinyIoC can be as simple as a single line of code:

```c#
// Auto-register all classes
TinyIoCContainer.Current.AutoRegister();
```

After that line is called, all classes have been registered and you are ready to go:

```c#
var controller = TinyIoCContainer.Current.Resolve<IController>();
```


You can also forgo the auto-registration and manually register individual components:

```c#
// Register individual classes with TinyIoC
TinyIoCContainer.Current.Register<UppercaseService>();
TinyIoCContainer.Current.Register<EchoService>();
```

TinyIoC works under both Xamarin.iOS and Xamarin.Android, as the sample applications show.

## License
[Apache License 2.0](LICENSE.md)
