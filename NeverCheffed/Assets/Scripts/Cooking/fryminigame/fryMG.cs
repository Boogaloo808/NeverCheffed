using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerInput PI;
    InputAction action;
    public float speed = 10f;
    public float maxDis;
    public float minDis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action = InputSystem.actions.FindAction("Player/Crouch");
        maxDis = rb.position.y + 2f;
        minDis = rb.position.y - 2f;
    }

    public void Update()
    {
        if (action.triggered)
        {
            if (rb.position.y < maxDis)
            {
                rb.velocity = transform.up * speed;
            }
            else
            {
                rb.velocity = transform.up * 0;
            }
        }
        else
        {
            if (rb.position.y > minDis)
            {
                rb.velocity = -transform.up * speed;
            }
            else
            {
                rb.velocity = -transform.up * 0;
            }
        }
    }
}
