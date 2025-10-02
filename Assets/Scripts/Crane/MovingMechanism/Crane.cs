using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Crane.MovingMechanism
{
    public class Crane : MonoBehaviour
    {
        [SerializeField]
        private LerpMovement m_beam;

        [SerializeField]
        private LerpMovement m_winch;

        public void ChangeMovementDirection(Vector3 direction)
        {
            m_winch.ChangeMovementDirection(direction.x);
            m_beam.ChangeMovementDirection(direction.z);
        }
    }
}