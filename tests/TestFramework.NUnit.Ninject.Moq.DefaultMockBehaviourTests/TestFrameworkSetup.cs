using Moq;

namespace TestFramework.NUnit.Ninject.Moq.DefaultMockBehaviourTests
{
    public class TestFrameworkSetup : ITestFrameworkSetup
    {
        public void Setup()
        {
            TestFrameworkConfiguration.DefaultMockBehavior = MockBehavior.Strict;

            Tests.TestFrameworkSetupCount ++;
        }
    }
}
