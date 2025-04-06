using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class splashscreen : MonoBehaviour
{

    public float waitTime = 5; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(1);
    }
}
