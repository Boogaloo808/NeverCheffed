using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateMG : MonoBehaviour
{
    public PlayerController controller;
    public GameObject Lock;
    public anchorMotor AM;
    public bool startedMG = false;
    
    void Start()
    {
        Lock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (controller.UsingCuttingStation == true)
        {
            Lock.SetActive(true);
            if (startedMG == false)
            {
                Debug.Log("Start minigame");
                AM.startMG();
                startedMG = true;
            }

        }
        else
        {
            Lock.SetActive(false);
            startedMG = false;

        }
    }
}
