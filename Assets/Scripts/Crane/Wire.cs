using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Crane
{
    public class Wire : MonoBehaviour
    {
        [SerializeField]
        private LineRenderer m_lineRenderer;

        [Space]

        [SerializeField]
        private Transform m_startPoint;

        [SerializeField]
        private Transform m_endPoint;


        private Transform m_transform;

        private void Awake()
        {
            m_transform = transform;
        }

        private void FixedUpdate()
        {
            m_lineRenderer.SetPosition(0, m_transform.InverseTransformPoint(m_startPoint.position));
            m_lineRenderer.SetPosition(1, m_transform.InverseTransformPoint(m_endPoint.position));
        }
    }
}