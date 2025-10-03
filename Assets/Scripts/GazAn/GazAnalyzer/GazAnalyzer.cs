using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer
{
    public class GazAnalyzer : MonoBehaviour
    {
        [SerializeField]
        private GazAnButton m_gazAnButton;

        [SerializeField]
        private GazAnDisplay m_gazAnDisplay;

        // ������ ����������


        public void SwitchStateDisplay()
        {
            m_gazAnDisplay.SwitchState();
        }
    }
}