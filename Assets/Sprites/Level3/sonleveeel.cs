using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonleveeel : MonoBehaviour
{
    [SerializeField] private GameObject text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(true);
            Destroy(text, 3f);
        }
    }
}
