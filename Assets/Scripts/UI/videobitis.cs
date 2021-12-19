using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videobitis : MonoBehaviour
{
    [SerializeField] private GameObject video;
    void Start()
    {
        StartCoroutine(introbas2());
    }

    IEnumerator introbas2()
    {
        yield return new WaitForSeconds(48f);
        SceneManager.LoadScene("Giris");
        video.SetActive(false);
        
    }
}
