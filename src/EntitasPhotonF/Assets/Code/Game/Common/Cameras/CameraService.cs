using Unity.Cinemachine;
using UnityEngine;

namespace Code.Game.Common.Cameras
{
    public class CameraService : MonoBehaviour, ICameraService
    {
        [SerializeField] private CinemachineCamera _cinemachineCamera;

        public void SetTarget(Transform target)
        {
            _cinemachineCamera.Follow = target;
        }
    }
}