using UnityEngine;
using UnityEngine.InputSystem;
public class DriveThroughWindow : MonoBehaviour
{
    public OrderTicket OrderTicket;
    public FoodList foodlist;
    private int rand;
    public bool takeOrder = false;
    public bool onwindow = false;
    public Gamepad gamepad = Gamepad.current;
    void Start()
    {
        
    }

    void Update()
    {
        if (takeOrder)
        {
            OrderTicket.ordered = true;
            
            takeOrder = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onwindow = true;
        }
        else
        {
            onwindow = false;
        }
    }

    public void grabOrder(InputAction.CallbackContext Context)
    {
        if (onwindow == true)
        {
            takeOrder = true;
        }
    }
}
