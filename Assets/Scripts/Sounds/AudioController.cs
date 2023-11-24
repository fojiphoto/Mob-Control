using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider musicSlider, sfxSlider;
    public static AudioController instance;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
       // LoadSettingSound();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMusicVolume()
    {
        AudioManager.Instance.ChangeMusicVolume(musicSlider.value);
    }
    public void ChangeSoundVolume()
    {
        AudioManager.Instance.ChangeSoundVolume(sfxSlider.value);
    }
    public void SaveSM()
    {
        if (!PlayerPrefs.HasKey("Save"))
        {
            PlayerPrefs.SetInt("Save", 1);
            PlayerPrefs.SetFloat("Sound", sfxSlider.value);
            PlayerPrefs.SetFloat("Music", musicSlider.value);
            PlayerPrefs.Save();
        }
    }

    public void LoadSettingSound()
    {
        if (PlayerPrefs.HasKey("Save"))
        {
            float sound = PlayerPrefs.GetFloat("Sound");
            sfxSlider.value = sound;
            float music = PlayerPrefs.GetFloat("Music");
            musicSlider.value = music;
        }
    }
}
