using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateMG : MonoBehaviour
{
    public PlayerController controller;
    public GameObject Lock;
    public anchorMotor AM;
    public PlayerInput playerinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lock.SetActive(false);
        playerinput.SwitchCurrentActionMap("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.UsingCuttingStation == true)
        {
            Lock.SetActive(true);
            AM.startMG();
            playerinput.SwitchCurrentActionMap("ChopMG");
        }
        else
        {
            Lock.SetActive(false);
            playerinput.SwitchCurrentActionMap("Player");
        }
    }
}
