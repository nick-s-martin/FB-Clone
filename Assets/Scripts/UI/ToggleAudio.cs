using UnityEngine;
using Scripts.SoundManagement;

namespace Scripts.UI
{
    public class ToggleAudio : MonoBehaviour
    { 

        [SerializeField] SoundManager soundManager;

        public void Toggle()
        {
            soundManager.ToggleAudio();
        }
    }
}