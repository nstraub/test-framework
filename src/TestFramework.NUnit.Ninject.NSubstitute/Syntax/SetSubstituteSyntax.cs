using Ninject.MockingKernel.NSubstitute;

namespace TestFramework.NUnit.Ninject.NSubstitute.Syntax
{
    public class SetSubstituteSyntax
    {
        private readonly NSubstituteMockingKernel kernel;

        internal SetSubstituteSyntax(NSubstituteMockingKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// Sets the substitute to the value in the next method call.
        /// </summary>
        /// <typeparam name="TSubstitute"></typeparam>
        /// <returns></returns>
        public SetSubstituteBuilder<TSubstitute> SubstituteFor<TSubstitute>()
        {
            return new SetSubstituteBuilder<TSubstitute>(kernel);
        }
    }
}
