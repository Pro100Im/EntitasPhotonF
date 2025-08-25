using Entitas;

namespace Code.Game.Features.Player.Systems
{
    public class AnimatePlayerMovementSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;

        public AnimatePlayerMovementSystem(GameContext gameContext)
        {
            _players = gameContext
                .GetGroup(GameMatcher
                .AllOf(GameMatcher.Player, GameMatcher.PlayerAnimator));
        }

        public void Execute()
        {
            foreach(var hero in _players)
            {
                if(hero.isMoving)
                    hero.playerAnimator.Value.PlayMove();
                else
                    hero.playerAnimator.Value.PlayIdle();
            }
        }
    }
}