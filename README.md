Inversion of Control on Xamarin.iOS and Xamarin.Android
=============

Two demo applications that show how to use inversion of control (IoC) container in a Xamarin.iOS and Xamarin.Android application. Most full blown IoC containers cannot be used on Xamarin.iOS and Xamarin.Android. There is one IoC container that is designed to be small, lightweight and easy to setup that _does_ work on Xamarin.iOS and Xamarin.Android: 
[TinyIoC](https://github.com/grumpydev/TinyIoC). This IoC container is nothing more than a single file that you can include in your project. Setting up TinyIoC is a single line of code:
```c#
    TinyIoCContainer.Current.AutoRegister();
```

After that line is called, all classes have been registered and you are ready to go:
```c#
    TinyIoCContainer.Current.Resolve<IController>();
```

TinyIoC works under both Xamarin.iOS and Xamarin.Android, as the sample applications show.