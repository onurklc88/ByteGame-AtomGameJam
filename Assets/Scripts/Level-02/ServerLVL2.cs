using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerLVL2 : MonoBehaviour
{
    [SerializeField] private GameObject serverGec;
    [SerializeField] private GameObject serverCamera;
    [SerializeField] private GameObject playerrr;
    [SerializeField] private GameObject healtB;
    [SerializeField] private GameObject minigame2info;
    [SerializeField] private AudioClip interact;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            serverGec.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            serverGec.SetActive(false);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(interact, 1f);
                minigame2info.SetActive(true);
                healtB.SetActive(false);
                playerrr.SetActive(false);
                serverCamera.SetActive(true);
                serverGec.SetActive(false);
                this.gameObject.SetActive(false);
                Destroy(minigame2info.gameObject, 5f);
            }
        }
    }
}
