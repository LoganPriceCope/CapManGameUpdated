using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    public float musicVolumeAmount;
    public float SFXVolumeAmount;

    public void Awake()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("MusicPlayerPrefs");
        _sfxSlider.value = PlayerPrefs.GetFloat("SFXPlayerPrefs");
    }

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
        PlayerPrefs.SetFloat("MusicPlayerPrefs", _musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
        PlayerPrefs.SetFloat("SFXPlayerPrefs", _sfxSlider.value);
    }
}
