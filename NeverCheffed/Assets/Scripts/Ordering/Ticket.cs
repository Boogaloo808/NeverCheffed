using System.Collections.Generic;
using System;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public int ticketNumber;

    public FoodCount FoodCount;
    public OrderTicket OrderTicket;
    public Transform panSlot;

    public GameObject _eggsAndBacon;
    public GameObject _burger;
    public GameObject _grilledCheese;
    public GameObject _salmonNigiri;
    void Start()
    {
        FoodCount = GameObject.Find("UI").GetComponent<FoodCount>();
        OrderTicket = GameObject.FindGameObjectWithTag("OTT").GetComponent<OrderTicket>();
        panSlot = GameObject.Find("panSlot").GetComponent<Transform>();
    }

    void Update()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("OTT").transform, false);

        if (ticketNumber == 0 && (FoodCount.EggNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2))
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.EggNumber -= 1;
            FoodCount.MeatNumber -= 1;
            FoodCount.SpiceNumber -= 2;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }

        if (ticketNumber == 1 && (FoodCount.CheeseNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.BreadNumber >= 1) && (FoodCount.VeggieNumber >= 2))
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.CheeseNumber -= 1;
            FoodCount.MeatNumber -= 1;
            FoodCount.BreadNumber -= 1;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }

        if (ticketNumber == 2 && (FoodCount.EggNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2))
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.EggNumber -= 1;
            FoodCount.MeatNumber -= 1;
            FoodCount.SpiceNumber -= 2;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }

        if (ticketNumber == 3 && (FoodCount.EggNumber >= 1f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2))
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);

            OrderTicket.haveOrder = false;

            FoodCount.EggNumber -= 1;
            FoodCount.MeatNumber -= 1;
            FoodCount.SpiceNumber -= 2;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
    }
}
