using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject ESCPanel2;

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
        ESCPanel2.SetActive(false);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene("Giris");
    }
    public void Quit()
    {
        Application.Quit();
    }


}
