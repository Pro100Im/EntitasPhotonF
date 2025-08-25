using Code.Game.Features.Player.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Game.Features.Player.Registrars
{
    public class PlayerAnimatorRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private PlayerAnimator _playerAnimator;

        public override void RegisterComponents()
        {
            Entity.AddPlayerAnimator(_playerAnimator);
            //Entity.AddDamageTakenAnimator(_playerAnimator);
        }

        public override void UnregisterComponents()
        {
            if(Entity.hasPlayerAnimator)
                Entity.RemovePlayerAnimator();

            //if(Entity.hasDamageTakenAnimator)
            //    Entity.RemoveDamageTakenAnimator();
        }
    }
}