using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class videoScript : MonoBehaviour
{
    [SerializeField] private GameObject intro;
    void Start()
    {
        StartCoroutine(introbas());
    }

    IEnumerator introbas()
    {
        yield return new WaitForSeconds(49f);
        intro.SetActive(false);
        SceneManager.LoadScene("Game");
    }
}
