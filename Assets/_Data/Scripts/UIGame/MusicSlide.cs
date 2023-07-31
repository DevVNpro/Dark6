using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlide : MonoBehaviour
{
    [SerializeField] protected AudioSource themeMusic;
    [SerializeField] protected AudioSource vfxMusic;
    [SerializeField] protected Slider musicSlider;
    [SerializeField] protected Slider vfxSlider;


    private void Update()
    {
        this.SetVolumeMusic();
    }
    protected virtual void SetVolumeMusic()
    {
        this.themeMusic.volume = this.musicSlider.value;
        this.vfxMusic.volume = this.vfxSlider.value;
    }

}
