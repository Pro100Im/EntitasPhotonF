using Code.Game.Common.Cameras;
using Entitas;
using UnityEngine;
using Zenject;

namespace Code.Game.Features.Player.Systems
{
    public class PlayerCameraInitSystem : IInitializeSystem
    {
        [Inject] private readonly LazyInject<ICameraService> _cameraService;

        private readonly GameContext _gameContext;

        private IGroup<GameEntity> _players;

        public PlayerCameraInitSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public void Initialize()
        {
            _players = _gameContext.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Player,
                GameMatcher.Transform));

            foreach(var player in _players)
            {
                if(_cameraService.Value == null)
                {
                    Debug.LogWarning("_cameraService.Value == null");
                }
                else
                    _cameraService.Value.SetTarget(player.transform.Value);
            }
        }
    }
}