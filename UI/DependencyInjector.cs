using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace UI
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer unityContainer = new UnityContainer();
        public static void Register<I, T>() where T : I
        {
            unityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }
        public static void InjectSub<I>(I instance)
        {
            unityContainer.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        }
        public static T Retrieve<T>()
        {
            return unityContainer.Resolve<T>();
        }

        public static void AddExtension<T>() where T : UnityContainerExtension
        {
            unityContainer.AddNewExtension<T>();
        }
    }
}
