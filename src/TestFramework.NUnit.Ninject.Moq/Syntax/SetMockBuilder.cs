using Ninject.MockingKernel.Moq;

namespace TestFramework.NUnit.Ninject.Moq.Syntax
{
    public class SetMockBuilder<TMock>
    {
        private readonly MoqMockingKernel kernel;

        internal SetMockBuilder(MoqMockingKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// Sets the mock object to the specified instance in the auto mocking container.
        /// </summary>
        /// <param name="instance">The instance to use.</param>
        public void To(TMock instance)
        {
            kernel.Bind<TMock>().ToConstant(instance);
        }

        /// <summary>
        /// Sets the mock object to null in the auto mocking container.
        /// </summary>
        public void ToNull()
        {
            var instance = default(TMock);
            To(instance);
        }
    }
}
