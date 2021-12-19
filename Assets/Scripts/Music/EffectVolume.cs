using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EffectVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float SliderValue)
    {
        mixer.SetFloat("Effect", Mathf.Log10(SliderValue) * 20);
    }
}
