using Business;

namespace UI
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IBusiness, BusinessClass>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
