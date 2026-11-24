using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundVolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private SoundMuter _soundMuter;
    [SerializeField] private string _exposedVolumeParameter;

    private float _divider = 20;

    private void OnEnable()
    {
        GetComponent<Slider>().onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        GetComponent<Slider>().onValueChanged.RemoveListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat(_exposedVolumeParameter, Mathf.Log10(volume) * _divider);
    }
}
