using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AudioCue_Channel : ScriptableObject
{
    public UnityAction<AudioClip> OnAudioCue;

    public void AudioCue(AudioClip _audioClip)
    {
        OnAudioCue?.Invoke(_audioClip);
    }
}
