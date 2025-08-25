using Code.Infrastructure.Systems;

namespace Code.GamePlay.Features.Hero
{
    public class PlayerFeature : Feature
    {
        public PlayerFeature(ISystemFactory systemFactory)
        {
            //Add(systemFactory.Create<InitializeHeroSystem>());

            //Add(systemFactory.Create<SetHeroDiractionalByInputSystem>());
            //Add(systemFactory.Create<CameraFollowHeroSystem>());
            //Add(systemFactory.Create<AnimateHeroMovementSystem>());
            //Add(systemFactory.Create<HeroDeathSystem>());

            //Add(systemFactory.Create<FinalizeHeroDeathProcessingSystem>());
        }
    }
}