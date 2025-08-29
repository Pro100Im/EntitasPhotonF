using Code.Game.Common.Cameras;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class GameServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindCommonServices();
        }

        private void BindCommonServices()
        {
            Container.BindInterfacesAndSelfTo<CameraService>().FromComponentInHierarchy().AsSingle();
        }
    }
}