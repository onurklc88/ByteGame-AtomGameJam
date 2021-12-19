using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{


    float[] rotations = { 0, 90, 180, 270 };

    public float[] correctRotatioýn;
    [SerializeField]
    bool isPlaced = false;
    int PossibleRots = 1;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    private void Start()
    {
        PossibleRots = correctRotatioýn.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.Rotate(0, 0, 90);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));
        

        if (PossibleRots > 1)
        {



            if (transform.eulerAngles.z == correctRotatioýn[0] || transform.eulerAngles.z == correctRotatioýn[1])
            {

                isPlaced = true;
                gameManager.correctMove();

            }

        }
        else
        {

            if (transform.eulerAngles.z == correctRotatioýn[0])
            {
                isPlaced = true;
                gameManager.correctMove();
            }

        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (PossibleRots > 1)
        {




            if (transform.eulerAngles.z == correctRotatioýn[0] || transform.eulerAngles.z == correctRotatioýn[1] && isPlaced == false)
            {

                isPlaced = true;
                gameManager.correctMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongway();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotatioýn[0] && isPlaced == false)
            {

                isPlaced = true;
                gameManager.correctMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongway();
            }

        }
         
    }
}
