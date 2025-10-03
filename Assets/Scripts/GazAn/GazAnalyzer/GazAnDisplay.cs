using TMPro;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer
{
    public class GazAnDisplay : MonoBehaviour
    {
        [SerializeField]
        private TextMeshPro m_dangerZoneDistanceText;

        [SerializeField]
        private DisplaySettings m_displaySettings;

        public EDisplayState DisplayState { get; private set; }

        private void Awake()
        {
            DisplayState = EDisplayState.Off;
        }

        public void SwitchState()
        {
            if (DisplayState == EDisplayState.Off) //Включаем экран
            {
                m_displaySettings.TurnOn();
                m_dangerZoneDistanceText.gameObject.SetActive(true);
                DisplayState = EDisplayState.On;
            }
            else if (DisplayState == EDisplayState.On) //Выключаем экран
            {
                m_displaySettings.TurnOff();
                m_dangerZoneDistanceText.gameObject.SetActive(false);
                DisplayState = EDisplayState.Off;
            }
        }

        public void SetDistanceDangerZone(float distance)
        {
            m_dangerZoneDistanceText.text = distance.ToString();
        }
    }
}