using Code.Game.Features.Input;
using Code.Game.Features.Movement;
using Code.Game.Features.Player.Systems;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Game.Features
{
    public class GameFeature : Feature
    {
        public GameFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<PlayerCameraInitSystem>());
            Add(systemFactory.Create<BindViewFeature>());

            Add(systemFactory.Create<InputFeature>());
            Add(systemFactory.Create<MovementFeature>());
        }
    }
}