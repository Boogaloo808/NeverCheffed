using System.Collections.Generic;
using System;
using UnityEngine;

public class CookCheck : MonoBehaviour
{
    public FoodCount FoodCount;
    public OrderTicket OrderTicket;
    public Transform panSlot;
    public Ticket ticket;

    public List<String> eggsAndBacon;
    public GameObject _eggsAndBacon;

    void Start()
    {
        
    }

    void Update()
    {
        ticket = GameObject.FindGameObjectWithTag("Ticket").GetComponent<Ticket>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Ticket"))
        {
            //if (Ticket.ticketNumber == 0 && (FoodCount.EggNumber >= 2f) && (FoodCount.MeatNumber >= 1f) && (FoodCount.SpiceNumber >= 2))
            {
                Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);

                OrderTicket.haveOrder = false;

                Debug.Log("ITS COOOKING");
            }
        }
    }
}
