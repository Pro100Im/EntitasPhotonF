using Code.Common.Entity;
//using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Game.Features.Player.Factory
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly IIdentifierService _identifiers;

        public PlayerFactory(IIdentifierService identifiers)
        {
            _identifiers = identifiers;
        }

        public GameEntity CreatePlayer(Vector3 at)
        {
            var entity = CreateEntity.Empty();
            entity.AddId(_identifiers.Next());
            entity.AddWorldPosition(at);
            entity.AddDirection(Vector2.zero);
            entity.AddSpeed(2);
            entity.AddViewPath("Game/Player/Player");
            entity.isPlayer = true;

            return entity;
        }
    }
}