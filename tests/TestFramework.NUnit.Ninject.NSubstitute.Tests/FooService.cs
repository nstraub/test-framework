using System;

namespace TestFramework.NUnit.Ninject.NSubstitute.Tests
{
    public interface IFooService
    {
        string DoFoo();
    }

    public class FooService : IFooService
    {
        public string DoFoo()
        {
            throw new NotImplementedException();
        }
    }
}