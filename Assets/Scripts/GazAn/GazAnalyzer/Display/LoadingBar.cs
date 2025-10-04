using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GazAn.GazAnalyzer.Display
{
    public class LoadingBar : MonoBehaviour
    {
        [SerializeField]
        private Image m_loadingImage;

        [SerializeField]
        private float m_fillingDuration = 3f;

        [SerializeField]
        private Ease m_easeType = Ease.InOutQuad;

        private Tweener m_fillingTweener;

        public void StartFilling()
        {
            m_fillingTweener = m_loadingImage.DOFillAmount(1f, m_fillingDuration).SetEase(m_easeType).OnComplete(() => m_loadingImage.fillAmount = 0f);
        }

        public void StopFilling()
        { 
            if (m_fillingTweener.IsActive())
            {
                m_fillingTweener.Kill();
                m_loadingImage.fillAmount = 0f;
            }
        }


    }
}