using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Crane.InputDevice
{
    public abstract class AbstractInputDevice : MonoBehaviour
    {
        [SerializeField]
        protected UnityEvent<Vector3> DirectionChanched;
    }
}