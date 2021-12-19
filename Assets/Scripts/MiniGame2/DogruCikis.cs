using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogruCikis : MonoBehaviour
{
    [SerializeField] private GameObject minigame2;
    [SerializeField] private GameObject playerrr;
    [SerializeField] private GameObject healtB;
    [SerializeField] private GameObject tebrikler;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FIS")
        {
            minigame2.SetActive(false);
            playerrr.SetActive(true);
            healtB.SetActive(true);
            tebrikler.SetActive(true);
            Destroy(tebrikler.gameObject, 4f);
            PlayerMovement.PM.bozuk2 = false;
        }
    }
}
