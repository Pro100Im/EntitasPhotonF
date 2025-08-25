using Entitas;

namespace Code.Game.Features.Player.Systems
{
    public class SetPlayerDiractionalByInputSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly IGroup<InputEntity> _inputs;

        public SetPlayerDiractionalByInputSystem(GameContext gameContext, InputContext inputContext)
        {
            _players = gameContext.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Player,
                GameMatcher.MovementAvailable));

            _inputs = inputContext.GetGroup(InputMatcher.Input);
        }

        public void Execute()
        {
            foreach(var input in _inputs)
            {
                foreach(var player in _players)
                {
                    player.isMoving = input.hasAxisInput;

                    if(input.hasAxisInput)
                        player.ReplaceDirection(input.axisInput.Value.normalized);
                }
            }
        }
    }
}