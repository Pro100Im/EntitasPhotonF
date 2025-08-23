using Code.Game.StaticData;
using Code.Infrastructure.Helpers;
using Code.Infrastructure.Loading;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using System;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller, ICoroutineRunner, IInitializable
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();

            BindInputService();
            BindSystemFactory();
            BindUIFactories();
            BindContexts();
            BindGameplayServices();
            BindStateMachine();
            BindStateFactory();
            BindGameStates();
        }

        private void BindInputService()
        {

        }

        private void BindSystemFactory()
        {
            
        }

        private void BindUIFactories()
        {
            
        }

        private void BindContexts()
        {
            
        }

        private void BindGameplayServices()
        {
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
        }

        private void BindStateMachine()
        {
            Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }

        private void BindGameStates()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadingHomeScreenState>().AsSingle();
            Container.BindInterfacesAndSelfTo<HomeScreenState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadingBattleState>().AsSingle();
            Container.BindInterfacesAndSelfTo<BattleEnterState>().AsSingle();
            Container.BindInterfacesAndSelfTo<BattleLoopState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
        }

        public void Initialize()
        {
            Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
        }
    }
}