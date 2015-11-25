using System;
using Ninject;
using Ninject.MockingKernel.Moq;
using NUnit.Framework;

namespace TestFramework.NUnit.Ninject.Moq.Example
{
    public interface IBar
    {
        string GetContent();
    }
    public interface IFoo
    {
        void DoStuff();
    }

    public class MyFoo : IFoo
    {
        private readonly IBar _bar;
        public MyFoo(IBar bar)
        {
            _bar = bar;
        }

        public void DoStuff()
        {
            Console.WriteLine(_bar.GetContent());
        }
    }


    [TestFixture]
    public class MyTests
    {
        private readonly MoqMockingKernel _kernel;

        public MyTests()
        {
            _kernel = new MoqMockingKernel();
            _kernel.Bind<IFoo>().To<MyFoo>();
        }

        [SetUp]
        public void SetUp()
        {
            _kernel.Reset();
        }

        [Test]
        public void Test1()
        {
            //setup the mock
            var barMock = _kernel.GetMock<IBar>();
            barMock.Setup(mock => mock.GetContent()).Returns("mocked Content");

            var foo = _kernel.Get<IFoo>(); // this will inject the mocked IBar into our normal MyFoo implementation
            foo.DoStuff();  // this will print "mocked Content", because the mocked object is called

            barMock.VerifyAll();
        }
    }

}
