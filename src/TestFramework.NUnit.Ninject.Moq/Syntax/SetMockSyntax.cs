using Ninject.MockingKernel.Moq;

namespace TestFramework.NUnit.Ninject.Moq.Syntax
{
    public class SetMockSyntax
    {
        private readonly MoqMockingKernel kernel;

        internal SetMockSyntax(MoqMockingKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// Sets the specified type to a specific instance in the auto mocking container.
        /// </summary>
        /// <typeparam name="TMock">The type to set.</typeparam>
        /// <returns></returns>
        public SetMockBuilder<TMock> Mock<TMock>()
        {
            return new SetMockBuilder<TMock>(kernel);
        }
    }
}
