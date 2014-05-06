using System;
using System.Threading.Tasks;

namespace thebigword.TestFramework.NSubstitute.Tests
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

        public async Task<string> DoFooAsync()
        {
            return await fooService.DoFooAsync();
        }
    }

    public interface IFooService
    {
        string DoFoo();
        Task<string> DoFooAsync();
    }

    public interface IBarService
    {
        string DoBar();
    }
}
