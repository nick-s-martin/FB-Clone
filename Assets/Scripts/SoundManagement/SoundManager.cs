using UnityEngine;
using System;

namespace Scripts.SoundManagement
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioCue_Channel _audioCue_Channel;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            /*_audioCue_Channel.OnAudioCue += PlayAudioCue;*/
        }

       /* private void PlayAudioCue()
        {
            Debug.Log(_audioClip);
        }*/

        public void ToggleAudio()
        {
            _audioSource.mute = !_audioSource.mute;
        }
    }
}