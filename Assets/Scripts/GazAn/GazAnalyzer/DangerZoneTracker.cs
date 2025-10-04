using System.Linq;
using UnityEngine;

namespace Assets.Scripts.GazAn.GazAnalyzer
{
    public class DangerZoneTracker
    {
        private readonly Transform m_gazAn;

        private readonly Transform[] m_dangerZones;

        public DangerZoneTracker(Transform gazAn, Transform[] dangerZones)
        {
            m_gazAn = gazAn;
            m_dangerZones = dangerZones;
        }

        public float GetDistanceNearestDangerZone()
        {
            return m_dangerZones.Min(zone => Vector3.Distance(m_gazAn.position, zone.position));
        }
    }
}