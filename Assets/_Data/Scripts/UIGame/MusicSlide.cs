using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlide : MonoBehaviour
{
    [SerializeField] protected AudioSource themeMusic;
    [SerializeField] protected Slider slider;

    private void Update()
    {
        this.SetVolumeMusic();
    }
    protected virtual void SetVolumeMusic()
    {
        this.themeMusic.volume = this.slider.value;
    }

}
