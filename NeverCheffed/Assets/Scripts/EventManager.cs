
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{

    public AudioSource bgMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Start()
    {
        bgMusic = GetComponent<AudioSource>();
        playMusic();
       
    }

    public void playMusic()
    {
        if (!bgMusic.isPlaying)
        {
            bgMusic.Play();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadLevel(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
