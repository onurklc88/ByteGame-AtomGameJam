using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float SliderValue)
    {
        mixer.SetFloat("Music", Mathf.Log10(SliderValue) * 20);
    }
}
