using UnityEngine;

public class DriveThroughWindow : MonoBehaviour
{
    public OrderTicket OrderTicket;
    public FoodList foodlist;
    private int rand;

    public bool takeOrder = false;

    void Start()
    {
        OrderTicket = GetComponent <OrderTicket>();
    }

    void Update()
    {
        if (takeOrder)
        {
            OrderTicket.ordered = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.Space))
        {
            takeOrder = true;

            Debug.Log("OrderTaken");
        }
    }
}
