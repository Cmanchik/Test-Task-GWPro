using TMPro;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer.Display
{
    public class GazAnDisplay : MonoBehaviour
    {
        [SerializeField]
        private TextMeshPro m_dangerZoneDistanceText;

        [SerializeField]
        private DisplaySettings m_displaySettings;

        public EDisplayState State { get; private set; }

        private void Awake()
        {
            State = EDisplayState.Off;
        }

        public void SwitchState()
        {
            if (State == EDisplayState.Off) //Включаем экран
            {
                m_displaySettings.TurnOn();
                m_dangerZoneDistanceText.gameObject.SetActive(true);
                State = EDisplayState.On;
            }
            else if (State == EDisplayState.On) //Выключаем экран
            {
                m_displaySettings.TurnOff();
                m_dangerZoneDistanceText.gameObject.SetActive(false);
                State = EDisplayState.Off;
            }
        }

        public void SetDistanceDangerZone(float distance)
        {
            m_dangerZoneDistanceText.text = $"{distance:F3}";
        }
    }
}