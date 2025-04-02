using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
