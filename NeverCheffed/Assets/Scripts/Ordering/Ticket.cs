using System.Collections.Generic;
using System;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public int ticketNumber;

    public FoodCount FoodCount;
    public OrderTicket OrderTicket;
    public Transform panSlot;



    public GameObject _FinishedFood;
    void Start()
    {
        FoodCount = GameObject.Find("UI").GetComponent<FoodCount>();
        OrderTicket = GameObject.FindGameObjectWithTag("OTT").GetComponent<OrderTicket>();
        panSlot = GameObject.Find("panSlot").GetComponent<Transform>();
    }

    void Update()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("OTT").transform, false);

        

        if (ticketNumber == 0 && (FoodCount.EggNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 1))
        {
                Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

                OrderTicket.haveOrder = false;

                FoodCount.EggNumber -= 1;
                FoodCount.MeatNumber -= 1;
                FoodCount.SpiceNumber -= 1;

                Destroy(gameObject);
            
            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 1 && (FoodCount.CheeseNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.BreadNumber >= 1) && (FoodCount.VeggieNumber >= 2))
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.CheeseNumber -= 1;
            FoodCount.MeatNumber -= 1;
            FoodCount.BreadNumber -= 1;
            FoodCount.VeggieNumber -= 2;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 2 && (FoodCount.BreadNumber >= 1f) && (FoodCount.CheeseNumber >= 1f))
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.BreadNumber -= 1;
            FoodCount.CheeseNumber -= 1;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 3 && (FoodCount.RiceNumber >= 1) && (FoodCount.MeatNumber >= 1f))
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.RiceNumber -= 1;
            FoodCount.MeatNumber -= 1;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 4 && (FoodCount.CheeseNumber >= 1) && (FoodCount.VeggieNumber >= 2f))
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.CheeseNumber -= 1;
            FoodCount.VeggieNumber -= 2;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
    }
}
