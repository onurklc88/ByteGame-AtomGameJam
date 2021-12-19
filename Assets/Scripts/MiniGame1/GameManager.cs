using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject PipesHolder;
    public GameObject[] Pipes;
    [SerializeField] private GameObject basarili;
    

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctedPipes = 0;



    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {

            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;


        }
    }
    private IEnumerator WaitForSecs()
    {
        yield return new WaitForSeconds(3f);
        ServerGecis.SG.healtbar.SetActive(true);
        ServerGecis.SG.serverCam.SetActive(false);
        ServerGecis.SG.playerr.SetActive(true);
        PlayerMovement.PM.bozuk = false;

    }

    public void correctMove()
    {
        correctedPipes += 1;
        Debug.Log("correct Move");

        if (correctedPipes == totalPipes)
        {
            basarili.SetActive(true);
            Destroy(basarili.gameObject, 3f);
            StartCoroutine(WaitForSecs());
            
            
            Debug.Log("You win!");


            
            
        }
      

    }


    public void wrongway()
    {
        correctedPipes -= 1;


    }
}





    
