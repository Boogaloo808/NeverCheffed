using System;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    float walkSpeed;
    float inputHorizontal;
    public bool activated = false;
    FoodList FoodList;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        walkSpeed = 5f;

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
}
