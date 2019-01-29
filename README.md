# EulerCSharpStarter

A starting point for solving Project Euler problems using C#.

## Give a Star! :star:

If you like this project, please give it a star. Thanks!

# Getting Started

You can either download/clone this repo, or probably better is to fork it to your own account. Then follow the instructions below.

## Visual Studio

Make sure you have the .NET Core SDK installed. From Visual Studio you can open and run the application. Modify the properties of the EulerSolver project under the Debug tab to specify command line arguments of `-p N` where N is the problem you want it to solve. Use ctrl-F5 to run the console application to solve that problem using your solver.

## Command Line

You can run the application from the command line using `dotnet run` in which case you pass arguments to the application following a `--`:

```
dotnet run -- -p 1
```

You can see an example here:

![image](https://user-images.githubusercontent.com/782127/51941449-9de32180-23e2-11e9-9671-93a1fe3e25d7.png)

## Tests

There is an example test in the XUnit test project. It's probably a good idea to write tests for any bits of algorithms that you can separate from the main `Solve` method. Run these using Visual Studio or with `dotnet test` from the test project folder.

