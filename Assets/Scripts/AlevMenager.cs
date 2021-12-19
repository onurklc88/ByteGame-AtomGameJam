using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlevMenager : MonoBehaviour
{
    [SerializeField] private GameObject Alev;
    [SerializeField] private float Delay = 1f;
    private float nextTime;
  

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn())
        {
            spawn();
        }
    }

    private void spawn()
    {
        nextTime = Time.time + Delay;
        Instantiate(Alev, transform.position, Quaternion.identity);
    }

    private bool shouldSpawn()
    {
        return Time.time >= nextTime;
    }
}
