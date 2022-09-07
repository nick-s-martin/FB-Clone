using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Scripts.UI
{
    public class ButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private Image _img;
        [SerializeField] Sprite _default, _pressed;

        public void OnPointerDown(PointerEventData eventData)
        {
            _img.sprite = _pressed;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _img.sprite = _default;
        }
    }
}