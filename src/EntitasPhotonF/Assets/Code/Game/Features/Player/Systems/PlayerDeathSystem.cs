using Entitas;

namespace Code.Game.Features.Player.Systems
{
    public class PlayerDeathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;

        public PlayerDeathSystem(GameContext game)
        {
            //_players = game.GetGroup(GameMatcher
            //  .AllOf(
            //    GameMatcher.Player,
            //    GameMatcher.Dead,
            //    GameMatcher.PlayerAnimator,
            //    GameMatcher.ProcessingDeath));
        }

        public void Execute()
        {
            //foreach(GameEntity hero in _heroes)
            //{
            //    hero.isMovementAvailable = false;

            //    hero.heroAnimator.Value.PlayDied();
            //}
        }
    }
}