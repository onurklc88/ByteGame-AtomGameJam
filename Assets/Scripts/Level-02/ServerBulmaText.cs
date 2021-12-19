using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerBulmaText : MonoBehaviour
{
    [SerializeField] private GameObject serverkayiptext;
    [SerializeField] private GameObject LVL2server;
    [SerializeField] private GameObject acilanduvar;

    void Start()
    {
        serverkayiptext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            serverkayiptext.SetActive(true);
            LVL2server.SetActive(true);
            acilanduvar.SetActive(false);
            Destroy(serverkayiptext.gameObject, 4f);
        }
    }
}
