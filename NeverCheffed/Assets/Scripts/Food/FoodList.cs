using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
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

    void Start()
    {

    }

    void Update()
    {
        
    }
}
