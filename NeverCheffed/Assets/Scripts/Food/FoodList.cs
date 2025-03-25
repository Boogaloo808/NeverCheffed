using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class FoodList : MonoBehaviour
{
    [Header("Rooms")]
    public GameObject[] fridgeRoom;
    public GameObject[] freezerRoom;
    public GameObject[] pantryRoom;
    public GameObject[] spiceRoom;

    [Header("Food")]
    public GameObject[] dishes;

    public List<GameObject> foodInPan;

    void Start()
    {
        foodInPan = new List<GameObject>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "food")
            foodInPan.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "food")
            foodInPan.Remove(collision.gameObject);
    }
}
