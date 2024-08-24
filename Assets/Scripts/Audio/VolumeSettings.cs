using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }

    public void MuteToggle(bool soundOn)
    {
        if (soundOn)
        {
            mixer.SetFloat("masterVolume", 0);
        }
        else
        {
            mixer.SetFloat("masterVolume", -80);
        }
    }

    public void SetMusicVolume()
    {
        float musicVolume = musicSlider.value;
        mixer.SetFloat("musicVolume", Mathf.Log10(musicVolume) * 20);
    }

    public void SetSFXVolume()
    {
        float SFXVolume = SFXSlider.value;
        mixer.SetFloat("sfxVolume", Mathf.Log10(SFXVolume) * 20);
        mixer.SetFloat("uiVolume", Mathf.Log10(SFXVolume) * 20);
    }
  
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetMusicVolume();
        SetSFXVolume();
    }
}
