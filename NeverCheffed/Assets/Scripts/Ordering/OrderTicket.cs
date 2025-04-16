using System.Collections.Concurrent;
using UnityEditor.Build;
using UnityEngine;

public class OrderTicket : MonoBehaviour
{
    public FoodList foodlist;
    private int rand;

    public bool ordered = false;
    void Start()
    {
        foodlist = GameObject.FindGameObjectWithTag("list of food").GetComponent<FoodList>();
    }

    void Update()
    {
        if (ordered)
        {
            rand = Random.Range(0, foodlist.recipes.Length);
            Instantiate(foodlist.recipes[rand], transform.position + Vector3.right, foodlist.recipes[rand].transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ticket"))
        {
            ordered = false;
        }
    }
}
