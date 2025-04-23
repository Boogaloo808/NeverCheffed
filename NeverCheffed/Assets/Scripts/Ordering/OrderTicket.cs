using System.Collections.Concurrent;
using UnityEditor.Build;
using UnityEngine;

public class OrderTicket : MonoBehaviour
{
    public FoodList foodlist;
    private int rand;

    public bool ordered = false;
    public bool haveOrder = false;
    void Start()
    {
        foodlist = GameObject.FindGameObjectWithTag("list of food").GetComponent<FoodList>();
    }

    void Update()
    {
        rand = Random.Range(0, foodlist.recipes.Length);
        if (ordered == true && haveOrder == false)
        {
                Instantiate(foodlist.recipes[rand], Vector3.zero, Quaternion.identity);
            haveOrder = true;
        }
        else
        {
            ordered = false;
        }
    }
}
