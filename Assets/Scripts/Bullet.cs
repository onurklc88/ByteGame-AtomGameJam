using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    [SerializeField] private Transform point;
    [SerializeField] private GameObject bullett;
    [SerializeField] private float bulletspeed = 660f;
    [SerializeField] private AudioClip fire;




    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        
    }


    public void shoot()
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(fire, 1f);
        GameObject bullet = Instantiate(bullett, point.position, point.rotation);
        Destroy(bullet, 4f);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(point.up * bulletspeed, ForceMode2D.Impulse);

        PlayerMovement.PM.anim.Play("Shot");
    }



}
