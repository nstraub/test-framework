using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestFramework.NUnit.Ninject.Moq.Extensions
{
    static class AssemblyExtensions
    {
        // Thanks Jon Skeet / Phil Haack
        // http://haacked.com/archive/2012/07/23/get-all-types-in-an-assembly.aspx

        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }
                
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}
