using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    cameraManager cam;
    public Transform cuttingboard;

    public PlayerInput playerinput;

    public bool usingPlayerAction = true;
    public bool usingChopMap = false;
    public bool usingcookMap = false;
    public bool usingfryMap = false;

    public float walkSpeed;
    public Vector2 move;
    public float inputX;
    float inputHorizontal;
    public bool activated = false;
    public bool atCuttingStation = false;
    FoodList FoodList;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = FindAnyObjectByType<cameraManager>();
        walkSpeed = 25f;
        move = new Vector2();
        //playerinput.SwitchCurrentActionMap("Player");

        FoodList = GetComponent<FoodList>();
    }

    void Update()
    {
        move.x = inputX;
        if (move == Vector2.zero)
        {
            rb.velocity *= 0.96f;
        }
        rb.AddForce(move * walkSpeed);

       if (Input.GetKeyDown(KeyCode.Space))
        {
            activated = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "kitchenWall":
                if (rb.velocity.x > 0.01f)
                {
                    cam.CookZoom(5);
                }
                if (rb.velocity.x < -0.01f)
                {
                    cam.CookZoom(5);
                }
                break;
            case "rightRoomWall":
                cam.RoomZoom(30, 10);
                break;
            case "leftRoomWall":
                cam.RoomZoom(-32, 10);
                break;
            case "cuttingboard":
                atCuttingStation = true;
                Debug.Log("At cutting Station");
                break;
            default:
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "cuttingboard":
                Debug.Log("left cutting Station");
                break;
        }

    }

    private void activateCutting()
    {
        if (atCuttingStation)
        {
            rb.transform.SetPositionAndRotation(cuttingboard.position, Quaternion.identity);
            switchController();

        }
    }

    public void playerMove(InputAction.CallbackContext Context)
    {
        inputX = Context.ReadValue<Vector2>().x;
    }

    public void playerInteract(InputAction.CallbackContext Context)
    {
        if (Context.started)
        {
            Debug.Log("interact");
            activateCutting();
        }
    }

    public void switchController()
    {
        if (usingPlayerAction)
        {
            playerinput.SwitchCurrentActionMap("ChopMG");
            usingPlayerAction = false;
        }
        else
        {
            playerinput.SwitchCurrentActionMap("Player");
            usingPlayerAction = true;
        }
    }
}
