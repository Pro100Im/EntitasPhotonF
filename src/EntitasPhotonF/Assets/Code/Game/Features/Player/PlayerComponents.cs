using Code.Game.Features.Player.Behaviours;
using Entitas;

namespace Code.Game.Features.Player 
{
    [Game] public class PlayerComponent : IComponent { }
    [Game] public class PlayerAnimatorComponent : IComponent { public PlayerAnimator Value; }
}