using UnityEngine;

namespace Scripts.UI
{
    public class ReadyMenu : MonoBehaviour
    {
        [SerializeField] Canvas canvas;

        public void OpenMenu()
        {
            canvas.enabled = true;
        }

        public void CloseMenu()
        {
            canvas.enabled = false;
        }
    }
}
