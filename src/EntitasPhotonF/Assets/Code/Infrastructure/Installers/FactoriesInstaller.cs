using Code.Common.Windows;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.Systems;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class FactoriesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSystemFactory();
            BindUIFactories();
            BindStateFactory();
        }

        private void BindSystemFactory()
        {
            Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
        }

        private void BindUIFactories()
        {
            Container.Bind<IWindowFactory>().To<WindowFactory>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }
    }
}
