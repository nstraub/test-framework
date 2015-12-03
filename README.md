Test Framework
==============

The test framework abstracts the boilerplate required to use an auto mocking container in a unit test project.  This means your test classes can focus on the job at hand, whilst all the setup and management of the auto mocking container is handled elsewhere.

Why?
====

Without the test framework or auto mocking, unit tests can easily become brittle and tiresome to maintain.  In this example every time a dependency is added to the service, we have to refactor it into all our existing tests before we can start writing new code.

``` c#
[Test]
public void DoWork_brittle_test()
{
    // Arrange
    var fooService = Substitute.For<IFooService>();
    var service = new Service(fooService);
            
    var input = "foo";
    var expected = "bar";

    // Act
    var actual = service.DoWork(input);

    // Assert
    actual.Should().Be(expected);
}
```  
In this version we use the test framework to instantiate the class we are testing.  The `GetService()` method simply wraps the auto mocking container, thus isolating our test class from it.

``` c#
[Test]
public void DoWork_robust_test()
{
    // Arrange
    var service = GetService();
    var input = "foo";
    var expected = "bar";

    // Act
    var actual = service.DoWork(input);

    // Assert
    actual.Should().Be(expected);
}
```

Installing
==========

Please install the appropiate package from NuGet:

````
PM> Install-Package TestFramework.NUnit.Ninject.Moq
````

or

````
PM> Install-Package TestFramework.NUnit.Ninject.NSubstitute
````

Documentation
=============

Please see the [wiki](https://github.com/kevinkuszyk/test-framework/wiki).

Credits
=======

The initial version of the framework was witten for [thebigword](http://www.thebigword.com).  Thank you to them and [@a-h](https://github.com/a-h) for agreeing to open source it.

Continuous Integration
======================

[![Build status](https://ci.appveyor.com/api/projects/status/ift4cef3mhf6tcc7)](https://ci.appveyor.com/project/kevinkuszyk/test-framework)

