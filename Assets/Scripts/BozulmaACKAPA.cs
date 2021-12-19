using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BozulmaACKAPA : MonoBehaviour
{

    [SerializeField] private GameObject bozukuntexti;

    // Start is called before the first frame update
    void Start()
    {
        bozukuntexti.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bozukuntexti.SetActive(true);
            StartCoroutine("WaitSec");
        }
    }
    IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(bozukuntexti.gameObject);
    }
}
