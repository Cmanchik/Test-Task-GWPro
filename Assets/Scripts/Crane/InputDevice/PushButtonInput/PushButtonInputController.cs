using Assets.Scripts.Crane.InputDevice.PushButtonInput.Button;
using UnityEngine;

namespace Assets.Scripts.Crane.InputDevice.PushButtonInput
{
    public class PushButtonInputController : AbstractInputDevice
    {
        [SerializeField] 
        private ControllerButton[] controllerButtons;

        private Vector3 directionMovement = Vector3.zero;

        private void Start()
        {
            foreach (var button in controllerButtons)
            {
                button.StateChanged += ControllerButton_ChangeCurrentDirection;
            }
        }

        private void ControllerButton_ChangeCurrentDirection(Vector3 changingDirection) 
        {
            directionMovement += changingDirection;
            DirectionChanched?.Invoke(directionMovement);
        }
    }
}