using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI.Buttons
{
    public class ButtonBase : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Animation Setup")]
        public float startDuration = 0.5f;
        public float hoverDuration = 0.2f;
        public float scaleHoverCoeficient = 1.1f;

        private Vector3 _startScale;

        private void Awake()
        {
            _startScale = transform.localScale;
        }

        private void OnEnable()
        {
            transform.DOScale(0, startDuration).From();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            DOTween.Kill(transform);
            transform.DOScale(_startScale * scaleHoverCoeficient, hoverDuration);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            DOTween.Kill(transform);
            transform.DOScale(_startScale, hoverDuration);
        }
    }
}
