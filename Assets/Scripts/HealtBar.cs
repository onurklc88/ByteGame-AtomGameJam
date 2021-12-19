using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    public static HealtBar HB;
    
    [SerializeField] private Slider slider;


    private void Awake()
    {
        HB = this;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }

}
