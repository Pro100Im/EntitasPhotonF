using UnityEngine;

namespace Code.Game.Features.Player.Behaviours
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private readonly int _isMovingHash = Animator.StringToHash("isMoving");
        private readonly int _attackHash = Animator.StringToHash("attack");
        private readonly int _diedHash = Animator.StringToHash("died");

        public void PlayMove() => _animator.SetBool(_isMovingHash, true);
        public void PlayIdle() => _animator.SetBool(_isMovingHash, false);

        public void PlayAttack() => _animator.SetTrigger(_attackHash);

        public void PlayDied() => _animator.SetTrigger(_diedHash);

        public void PlayDamageTaken()
        {

        }

        public void ResetAll()
        {
            _animator.ResetTrigger(_attackHash);
            _animator.ResetTrigger(_diedHash);
        }
    }
}