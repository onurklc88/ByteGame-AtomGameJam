using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HataliCikis : MonoBehaviour
{
    [SerializeField] private GameObject HataliText;

    // Start is called before the first frame update
    void Start()
    {
        HataliText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FIS")
        {
            HataliText.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FIS")
        {
            HataliText.SetActive(false);
        }
    }
}
