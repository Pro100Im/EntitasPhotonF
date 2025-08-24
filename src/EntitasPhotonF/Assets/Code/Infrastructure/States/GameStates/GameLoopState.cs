using Code.Infrastructure.States.StateInfrastructure;

using System.Collections;

namespace Code.Infrastructure.States.GameStates
{
    public class GameLoopState : IState, IUpdateable
    {
        //private BattleFeature _battleFeature;

        //public BattleLoopState(ISystemFactory systems, GameContext gameContext)
        //{
        //    _systems = systems;
        //    _gameContext = gameContext;
        //}

        public void Enter()
        {
            //_battleFeature = _systems.Create<BattleFeature>();
            //_battleFeature.Initialize();
        }

        public void Update()
        {
            //_battleFeature?.Execute();
            //_battleFeature?.Cleanup();
        }

        public void Exit()
        {
            //_battleFeature.DeactivateReactiveSystems();
            //_battleFeature.ClearReactiveSystems();

            DestructEntities();

            //_battleFeature.Cleanup();
            //_battleFeature.TearDown();
            //_battleFeature = null;
        }

        private void DestructEntities()
        {
            //foreach(GameEntity entity in _gameContext.GetEntities())
            //    entity.isDestructed = true;
        }
    }
}