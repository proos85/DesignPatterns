using System.Reflection;
using Ninject;

namespace Patterns.Testing._1_With_Testing.IoC
{
    public class DependencyContainer
    {
        private static DependencyContainer _instance;
        private static readonly object Padlock = new object();

        private static IKernel _kernel;

        DependencyContainer() {}

        public static DependencyContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DependencyContainer();
                            _instance.InitializeContainer();
                        }

                        return _instance;
                    }
                }
                return _instance;
            }
        }

        private void InitializeContainer()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
        }

        public T GetInstance<T>()
        {
            var dependeny = _kernel.Get<T>();
            return dependeny;
        }
    }
}