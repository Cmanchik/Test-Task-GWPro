using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer.Rope
{
    public class RopeRenderer : MonoBehaviour
    {
        [SerializeField]
        private LineRenderer m_lineRenderer;

        [SerializeField]
        private Transform[] m_ropeSegments;

        private void Start()
        {
            m_lineRenderer.positionCount = m_ropeSegments.Length;
        }

        private void Update()
        {
            for (int i = 0; i < m_lineRenderer.positionCount; i++)
            {
                m_lineRenderer.SetPosition(i, m_ropeSegments[i].position);
            }
        }
    }
}