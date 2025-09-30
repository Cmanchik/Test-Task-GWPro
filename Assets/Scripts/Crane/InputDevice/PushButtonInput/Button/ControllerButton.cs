using HTC.UnityPlugin.ColliderEvent;
using System;
using UnityEngine;


namespace Assets.Scripts.Crane.InputDevice.PushButtonInput.Button
{
    public class ControllerButton : MonoBehaviour, IColliderEventPressEnterHandler, IColliderEventPressExitHandler
    {
        [SerializeField]
        private Vector3 m_directionMovement;

        public event Action<Vector3> StateChanged;

        public void OnColliderEventPressEnter(ColliderButtonEventData eventData)
        {
            StateChanged?.Invoke(m_directionMovement);
        }

        public void OnColliderEventPressExit(ColliderButtonEventData eventData)
        {
            StateChanged?.Invoke(-m_directionMovement);
        }
    }
}