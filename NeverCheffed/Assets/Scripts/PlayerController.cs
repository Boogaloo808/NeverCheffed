using System;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    cameraManager cam;

    float walkSpeed;
    float inputHorizontal;
    public bool activated = false;
    FoodList FoodList;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = FindAnyObjectByType<cameraManager>();
        walkSpeed = 7f;

        FoodList = GetComponent<FoodList>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector2(inputHorizontal *  walkSpeed, 0f));

        if (Input.GetKeyDown(KeyCode.Space) && !activated)
        {
            activated = true;
            Debug.Log(activated);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && activated)
        {
            activated = false;
            Debug.Log(activated);
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
            default:
                break;
        }
    }
}
