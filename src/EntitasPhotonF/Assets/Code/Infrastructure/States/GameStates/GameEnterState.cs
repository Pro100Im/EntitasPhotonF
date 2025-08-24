using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
    public class GameEnterState : SimpleState
    {
        private readonly IGameStateMachine _stateMachine;

        public GameEnterState(
          IGameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public override void Enter()
        {
            PlaceHero();

            _stateMachine.Enter<GameLoopState>();
        }

        private void PlaceHero()
        {
            
        }
    }
}