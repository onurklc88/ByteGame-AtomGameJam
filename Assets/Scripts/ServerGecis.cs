using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerGecis : MonoBehaviour
{
    public static ServerGecis SG;
    public GameObject ServerGecisi;
    public GameObject serverCam;
    public GameObject playerr;
    public GameObject healtbar;
    public GameObject minigame1info;
    public GameObject servercikis;
    [SerializeField] private AudioClip interact;


    private void Awake()
    {
        SG = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ServerGecisi.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ServerGecisi.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ServerGecisi.SetActive(false);

        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(interact, 1f);
                servercikis.SetActive(false);
                minigame1info.SetActive(true);
                healtbar.SetActive(false);
                playerr.SetActive(false);
                serverCam.SetActive(true);
                ServerGecisi.SetActive(false);
                this.gameObject.SetActive(false);
                Destroy(minigame1info.gameObject, 5f);
            }
        }
    }

    /*IEnumerator CloseInfo()
    {
        yield return new WaitForSeconds(4);
        Destroy(minigame1info.gameObject);
    }*/

}
