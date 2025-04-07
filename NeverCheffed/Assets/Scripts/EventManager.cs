using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public AudioSource bgMusic;
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
