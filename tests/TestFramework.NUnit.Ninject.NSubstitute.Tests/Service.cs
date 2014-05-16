using System;
using System.Threading.Tasks;

namespace TestFramework.NUnit.Ninject.NSubstitute.Tests
{
    public class Service
    {
        private readonly IFooService fooService;
        private readonly IBarService barService;

        public Service(IFooService fooService, IBarService barService)
        {
            if (fooService == null)
            {
                throw new ArgumentNullException("fooService");
            }

            this.fooService = fooService;
            this.barService = barService;
        }

        public string DoFoo()
        {
            return fooService.DoFoo();
        }
    }

    public interface IFooService
    {
        string DoFoo();
    }

    public interface IBarService
    {
        string DoBar();
    }
}