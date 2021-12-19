using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GirisScript : MonoBehaviour
{
    [SerializeField] private GameObject videoP;
    [SerializeField] private GameObject startkapa;
    [SerializeField] private GameObject quitkapa;

    public void Startgamebutton()
    {
        videoP.SetActive(true);
        startkapa.SetActive(false);
        quitkapa.SetActive(false);
        //SceneManager.LoadScene("Game");
    }

    public void quitGamee()
    {
        Application.Quit();
    }
}
