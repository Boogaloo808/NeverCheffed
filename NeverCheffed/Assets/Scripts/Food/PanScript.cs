using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public List<GameObject> foodInPan;
    public Transform FFT;
    public FoodCount counter;
    public Collider2D panCollider;
    
    public GameManager manager;

    void Start()
    {
        foodInPan = new List<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cheese"))
            counter.CheeseNumber++;

        Debug.Log(true);
    }
}
