using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Crane.MovingMechanism
{
    public class LerpMovement : MonoBehaviour
    {
        [SerializeField]
        private Transform m_positvePoint;

        [SerializeField] 
        private Transform m_negativePoint;

        [Space]

        [SerializeField]
        private float m_positiveSpeed;

        [SerializeField]
        private float m_negativeSpeed;


        private Transform m_currentTarget;
        private float m_currentSpeed;

        private Transform m_transform;

        private void Awake()
        {
            m_transform = transform;
        }

        public void ChangeMovementDirection(float direction)
        {
            if (direction > 0)
            {
                m_currentTarget = m_positvePoint;
                m_currentSpeed = m_positiveSpeed;
            }
            else if (direction < 0)
            {
                m_currentTarget = m_negativePoint;
                m_currentSpeed = m_negativeSpeed;
            }
            else
            {
                m_currentTarget = null;
                m_currentSpeed = 0;
            }
        }

        private void FixedUpdate()
        {
            if (m_currentTarget != null)
            {
                m_transform.position = Vector3.MoveTowards(m_transform.position, m_currentTarget.position, m_currentSpeed);
            }
        }
    }
}