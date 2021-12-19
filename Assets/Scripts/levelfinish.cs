using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelfinish : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform TP;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.transform.position = TP.transform.position;
        }
    }

}
