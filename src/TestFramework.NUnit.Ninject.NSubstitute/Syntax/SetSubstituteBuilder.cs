﻿using Ninject;
using Ninject.MockingKernel.NSubstitute;

namespace TestFramework.NUnit.Ninject.NSubstitute.Syntax
{
    public class SetSubstituteBuilder<TSubstitute>
    {
        private readonly NSubstituteMockingKernel kernel;

        internal SetSubstituteBuilder(NSubstituteMockingKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// Sets the substitute object to the specified instance in the auto mocking container.
        /// </summary>
        /// <param name="instance">The instance to use.</param>
        public void To(TSubstitute instance)
        {
            kernel.Bind<TSubstitute>().ToConstant(instance);
        }

        /// <summary>
        /// Sets the substitute object to null in the auto mocking container.
        /// </summary>
        public void ToNull()
        {
            var instance = default(TSubstitute);
            To(instance);
        }

        /// <summary>
        /// Sets the substitute object to an instance of the specified type in the auto mocking container.
        /// </summary>
        /// <typeparam name="TConcrete">The type to use.</typeparam>
        public void To<TConcrete>() where TConcrete: TSubstitute
        {
            kernel.Bind<TSubstitute>().To<TConcrete>();
        }
    }
}
