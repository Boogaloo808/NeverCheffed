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
        if (collision.gameObject.CompareTag("Milk"))
            counter.MilkNumber++;
        if (collision.gameObject.CompareTag("Meat"))
            counter.MeatNumber++;
        if (collision.gameObject.CompareTag("Egg"))
            counter.EggNumber++;
        if (collision.gameObject.CompareTag("Rice"))
            counter.RiceNumber++;
        if (collision.gameObject.CompareTag("Flour"))
            counter.FlourNumber++;
        if (collision.gameObject.CompareTag("Spice"))
            counter.SpiceNumber++;
        if (collision.gameObject.CompareTag("Bread"))
            counter.BreadNumber++;
    }
}
