using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serverTEXT2 : MonoBehaviour
{
    [SerializeField] private GameObject acilcak;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            acilcak.SetActive(true);
            Destroy(acilcak.gameObject, 5f);
        }
    }
}
