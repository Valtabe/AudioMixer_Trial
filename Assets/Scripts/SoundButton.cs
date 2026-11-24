using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(PlaySound);
    }

    private void OnDisable()
    {
        GetComponent<Button>().onClick.RemoveListener(PlaySound);
    }

    public void PlaySound()
    {
        _audioSource.Play();
    }
}
