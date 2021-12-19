using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmus : MonoBehaviour
{
    public static BGmus bgmus;

    private void Awake()
    {
        if (bgmus != null && bgmus != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgmus = this;
        DontDestroyOnLoad(this);
    }
}
