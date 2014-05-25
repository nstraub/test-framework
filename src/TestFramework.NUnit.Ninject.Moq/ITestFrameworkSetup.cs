
namespace TestFramework.NUnit.Ninject.Moq
{
    /// <summary>
    /// Implement this interface to override the test framework global configuration.
    /// </summary>
    public interface ITestFrameworkSetup
    {
        /// <summary>
        /// Implement this method to make changes to the test framework global configuration
        /// </summary>
        void Setup();
    }
}
