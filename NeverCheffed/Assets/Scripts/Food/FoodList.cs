using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FoodList : MonoBehaviour
{
    [Header("Rooms")]
    public GameObject[] fridgeRoom;
    public GameObject[] pantryRoom;

    [Header("Recipes")]
    public GameObject[] recipes;

    [Header("Food")]
    public GameObject[] dishes;

    void Start()
    {

    }

    void Update()
    {
        
    }
}
