using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;

namespace Code.Infrastructure.States.GameStates
{
    public class BattleEnterState : SimpleState
    {
        private readonly IGameStateMachine _stateMachine;

        public BattleEnterState(
          IGameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public override void Enter()
        {
            PlaceHero();

            _stateMachine.Enter<BattleLoopState>();
        }

        private void PlaceHero()
        {
            
        }
    }
}