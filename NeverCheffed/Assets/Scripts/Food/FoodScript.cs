using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    PlayerController player;
    Transform food;
    Transform pan;
    PanScript panScript;

    void Start()
    {
        panScript = GetComponent<PanScript>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
