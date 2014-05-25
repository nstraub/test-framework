using Moq;

namespace TestFramework.NUnit.Ninject.Moq
{
    /// <summary>
    /// Global configuration for the test framework.
    /// </summary>
    public static class TestFrameworkConfiguration
    {
        private static MockBehavior defaultMockBehavior = MockBehavior.Default;

        /// <summary>
        /// The default mock behaviour for mocks created by the auto mocking container.
        /// </summary>
        public static MockBehavior DefaultMockBehavior
        {
            get { return defaultMockBehavior; }
            set { defaultMockBehavior = value; }
        }

        /// <summary>
        /// Have we attempted to load the user's test framework setup.
        /// </summary>
        internal static bool UserSetupLoaded { get; set; }
    }
}
