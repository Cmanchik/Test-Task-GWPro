using System.Linq;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer
{
    public class GazAnalyzer : MonoBehaviour
    {
        [SerializeField]
        private GazAnButton m_gazAnButton;

        [SerializeField]
        private GazAnDisplay m_gazAnDisplay;

        private DangerZoneTracker m_zoneTracker;

        private void Awake()
        {
            m_zoneTracker = new DangerZoneTracker
                (
                    transform, 
                    GameObject.FindGameObjectsWithTag("DangerZone").Select(zone => zone.GetComponent<Transform>()).ToArray()
                );
        }


        public void SwitchStateDisplay()
        {
            m_gazAnDisplay.SwitchState();
        }

        private void Update()
        {
            if (m_gazAnDisplay.State == EDisplayState.On)
            {
                m_gazAnDisplay.SetDistanceDangerZone(m_zoneTracker.GetDistanceNearestDangerZone());
            }
        }
    }
}