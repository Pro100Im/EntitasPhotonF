using Code.Game.Input;
using Code.Infrastructure.Systems;

namespace Code.Game.Features
{
    public class GameFeature : Feature
    {
        public GameFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InputFeature>());
        }
    }
}