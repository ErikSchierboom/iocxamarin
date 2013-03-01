Inversion of Control on Xamarin.iOS
=============

A demo application that shows how to use an inversion of control (IoC) container in a Xamarin.iOS or Xamarin.Android application. Most full blown IoC containers do not work out of the box the Xamarin.iOS platform. There is one IoC container that it easy to setup and does work on Xamarin.iOS and Xamarin.Android: [https://github.com/grumpydev/TinyIoC/](TinyIoC).

This IoC container is nothing more than a single file that you can include in your project. Setting up TinyIoC is a single line of code:
```c#
    TinyIoCContainer.Current.AutoRegister();
```

After that line is called, all classes have been registered and you are ready to go:
```c#
    TinyIoCContainer.Current.Resolve<IController>();
```