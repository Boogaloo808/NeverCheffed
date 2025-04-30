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
    void Start()
    {
        FoodCount = GameObject.Find("UI").GetComponent<FoodCount>();
        OrderTicket = GameObject.FindGameObjectWithTag("OTT").GetComponent<OrderTicket>();
        panSlot = GameObject.Find("panSlot").GetComponent<Transform>();
    }

    void Update()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("OTT").transform, false);

        if (ticketNumber == 0 && (FoodCount.EggNumber >= 2f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2))
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);
            transform.SetParent(GameObject.FindGameObjectWithTag("panSlot").transform, false);

            OrderTicket.haveOrder = false;

            Destroy(gameObject);

            Debug.Log("ITS COOOKING");
        }
    }
}
