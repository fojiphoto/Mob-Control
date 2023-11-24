using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sounds[] MusicSound, SFXSounds;
    public AudioSource musicsource, sfxsource;
    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayMusic(string name)
    {
        Sounds s = Array.Find(MusicSound, x => x.Name == name);
        if (s==null)
        {
            Debug.Log("Song not found");
        }
        else
        {
            musicsource.clip = s.clip;
            musicsource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sounds s = Array.Find(SFXSounds, x => x.Name == name);
        if (s == null)
        {
            Debug.Log("Sound not found");
        }
        else
        {
            sfxsource.PlayOneShot(s.clip);
        }
    }

    public void ChangeMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }
    public void ChangeSoundVolume(float volume)
    {
        sfxsource.volume = volume;
    }
}
