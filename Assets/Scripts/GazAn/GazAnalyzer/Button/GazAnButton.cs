using HTC.UnityPlugin.ColliderEvent;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.GazAn.GazAnalyzer.Button
{
    public class GazAnButton : MonoBehaviour, IColliderEventPressEnterHandler, IColliderEventPressExitHandler
    {
        [SerializeField]
        private float m_switchingStateDelay;

        [SerializeField]
        private UnityEvent m_stateSwitched;

        [SerializeField]
        private UnityEvent m_PressEnter;

        [SerializeField]
        private UnityEvent m_PressExit;

        private Coroutine m_switchingStateCoroutine;

        private bool m_isPressed;

        public void OnColliderEventPressEnter(ColliderButtonEventData eventData)
        {
            m_isPressed = true;
            m_PressEnter?.Invoke();
            m_switchingStateCoroutine = StartCoroutine(SwitchState());
        }

        public void OnColliderEventPressExit(ColliderButtonEventData eventData)
        {
            m_isPressed = false;
            m_PressExit?.Invoke();
            StopCoroutine(m_switchingStateCoroutine);
        }

        private IEnumerator SwitchState()
        {
            yield return new WaitForSeconds(m_switchingStateDelay);

            if (m_isPressed)
            {
                m_stateSwitched?.Invoke();
            }
        }
    }
}