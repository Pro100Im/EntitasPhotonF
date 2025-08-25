using System.Collections.Generic;
using Entitas;

namespace Code.Game.Features.Player.Systems
{
    public class FinalizePlayerDeathProcessingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        //private readonly List<GameEntity> _buffer = new(1);

        //public FinalizePlayerDeathProcessingSystem(GameContext game)
        //{
        //    _heroes = game.GetGroup(GameMatcher
        //      .AllOf(
        //        GameMatcher.Player,
        //        GameMatcher.Dead,
        //        GameMatcher.ProcessingDeath));
        //}

        public void Execute()
        {
            //    foreach(GameEntity hero in _heroes.GetEntities(_buffer))
            //    {
            //        hero.isProcessingDeath = false;
            //    }
            //}
        }
    }
}