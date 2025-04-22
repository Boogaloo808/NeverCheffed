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
        if (ordered == true)
        {
            rand = Random.Range(0, foodlist.recipes.Length);
            //Instantiate(foodlist.recipes[rand], transform.position + Vector3.right, foodlist.recipes[rand].transform.rotation);
            Instantiate(foodlist.recipes[rand], Vector3.zero, Quaternion.identity);

            ordered = false;
        }
    }


}
