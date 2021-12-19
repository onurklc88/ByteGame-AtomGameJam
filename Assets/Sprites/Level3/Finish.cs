using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject cutscene2;
    [SerializeField] private GameObject bgmus;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0.0f;
            cutscene2.SetActive(true);
            Destroy(bgmus.gameObject);
            StartCoroutine(introbas2());
        }
    }

    

    IEnumerator introbas2()
    {
        yield return new WaitForSeconds(48f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        cutscene2.SetActive(false);

    }
}
