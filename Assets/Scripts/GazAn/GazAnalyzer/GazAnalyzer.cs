using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer
{
    public class GazAnalyzer : MonoBehaviour
    {
        [SerializeField]
        private GazAnButton m_gazAnButton;

        [SerializeField]
        private GazAnDisplay m_gazAnDisplay;

        // Трекер расстояния


        public void SwitchStateDisplay()
        {
            m_gazAnDisplay.SwitchState();
        }
    }
}