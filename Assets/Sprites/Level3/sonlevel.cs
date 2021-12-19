using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonlevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject text1;

    private void Start()
    {
        text1.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text1.SetActive(true);
            Destroy(text1, 3f);
        }
    }

}
