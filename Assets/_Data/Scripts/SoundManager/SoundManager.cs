using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    protected static SoundManager instance;
    public static SoundManager Instance => instance;

    [SerializeField] protected AudioSource musicSource, effectsSource;
    [SerializeField] public Music[] musicSources, effectsSources;

    protected virtual void Awake()
    {
        if (instance != null) Debug.LogError("Only 1 AudioSoure allow to exist");
        instance = this;
        
    }
    private void Start()
    {
        this.PlayThemeMusic("Theme");
    }
    public void PlayThemeMusic(string name)
    {
        foreach(Music music in musicSources)
        {
            if (music.nameClip == name)
            {
                musicSource.clip = music.clip;
                musicSource.Play();
            }
        }
    }
    public void PlayVFXmusic(string name)
    {
        foreach(Music music in effectsSources)
        {
            if(name == music.nameClip)
            {
                effectsSource.clip = music.clip;
                effectsSource.Play();
            }
        }    
    }  

  
    

}
