using Ninject;
using System.Reflection;

namespace BLinkerTest.Ninject
{
    static class DepInj
    {
        static StandardKernel _Kernel;

        static public void Initialize()
        {
            _Kernel = new StandardKernel();
            _Kernel.Load(Assembly.GetExecutingAssembly());
        }

        static public T Create<T>()
        {
            return _Kernel.Get<T>();
        }
    }
}
