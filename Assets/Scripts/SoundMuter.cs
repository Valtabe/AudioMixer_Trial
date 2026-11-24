using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundMuter : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _master;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private Image _mask;
    [SerializeField] private string _expodesVolumeParameter;

    private bool _isMuted;
    private float _minVolume = -80;
    private float _maxVolume = 0;

    private void Start()
    {
        _isMuted = false;
        _mask.gameObject.SetActive(false);
    }

    public void ToggleMute()
    {
        if (_isMuted)
        {
            _isMuted = false;
            _master.audioMixer.SetFloat(_expodesVolumeParameter, _maxVolume);
        }
        else
        {
            _isMuted = true;
            _master.audioMixer.SetFloat(_expodesVolumeParameter, _minVolume);
        }

        _mask.gameObject.SetActive(_isMuted);
    }
}
