using System;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer.Display
{
    [Serializable]
    public class DisplaySettings
    {
        [SerializeField]
        private Renderer m_displayMeshRender;

        [SerializeField]
        private int m_materialIndex;

        [Space]

        [SerializeField]
        private Material m_displayOffMaterial;

        [SerializeField]
        private Material m_displayOnMaterial;

        public void TurnOn()
        {
            Material[] materials = m_displayMeshRender.materials;
            materials[1] = m_displayOnMaterial;
            m_displayMeshRender.materials = materials;
        }

        public void TurnOff()
        {
            Material[] materials = m_displayMeshRender.materials;
            materials[1] = m_displayOffMaterial;
            m_displayMeshRender.materials = materials;
        }
    }
}