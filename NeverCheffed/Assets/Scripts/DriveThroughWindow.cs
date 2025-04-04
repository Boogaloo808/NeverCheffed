using UnityEngine;

public class DriveThroughWindow : MonoBehaviour
{

    public bool takeOrder = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (takeOrder)
        {

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.Space))
        {
            takeOrder = true;
        }
    }
}
