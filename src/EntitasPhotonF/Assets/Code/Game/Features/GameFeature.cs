using Code.Game.Features.Input;
using Code.Game.Features.Movement;
using Code.Infrastructure.Systems;

namespace Code.Game.Features
{
    public class GameFeature : Feature
    {
        public GameFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InputFeature>());
            Add(systemFactory.Create<MovementFeature>());
        }
    }
}