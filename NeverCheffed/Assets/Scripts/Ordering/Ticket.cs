using System.Collections.Generic;
using System;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public int ticketNumber;

    public FoodCount FoodCount;
    public OrderTicket OrderTicket;
    public Transform panSlot;
    public anchorMotor am;

    public bool haveIng = false;

    public GameObject _FinishedFood;
    void Start()
    {
        FoodCount = GameObject.Find("UI").GetComponent<FoodCount>();
        OrderTicket = GameObject.FindGameObjectWithTag("OTT").GetComponent<OrderTicket>();
        panSlot = GameObject.Find("panSlot").GetComponent<Transform>();
        am = GameObject.Find("AM to Ticket").GetComponent<AMtoTicket>().AM;
    }

    void Update()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("OTT").transform, false);

        

        if (ticketNumber == 0 && (FoodCount.EggNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2) && am.cooked)
        {
                Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

                OrderTicket.haveOrder = false;

                FoodCount.EggNumber -= 1;
                FoodCount.MeatNumber -= 1;
                FoodCount.SpiceNumber -= 2;

                Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 1 && (FoodCount.CheeseNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.BreadNumber >= 1) && (FoodCount.VeggieNumber >= 2) && am.cooked)
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
        else if (ticketNumber == 2 && (FoodCount.BreadNumber >= 1f) && (FoodCount.CheeseNumber >= 1f) && am.cooked)
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.BreadNumber -= 1;
            FoodCount.CheeseNumber -= 1;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
        else if (ticketNumber == 3 && (FoodCount.RiceNumber >= 1) && (FoodCount.MeatNumber >= 1f) && am.cooked)
        {
            Instantiate(_FinishedFood, panSlot.transform.position, _FinishedFood.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.RiceNumber -= 1;
            FoodCount.MeatNumber -= 1;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
    }
}
