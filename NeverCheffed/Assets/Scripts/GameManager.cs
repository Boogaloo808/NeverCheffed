using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    FoodList FoodList;
    PanScript panScript;

    public GameObject[] eggsAndBacon;
    public GameObject _eggsAndBacon;
    public Transform panSlot;
    public PanScript pan;

    public bool Cooked = false;

    void Start()
    {
        FoodList = GetComponent<FoodList>();
        panScript = GameObject.FindGameObjectWithTag("Pan").GetComponent<PanScript>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !Cooked)
        {
            Cooked = true;
            Invoke("RecipeList", 0f);

            Debug.Log(Cooked);
        }
    }

    void RecipeList()
    {
        if (eggsAndBacon.SequenceEqual(panScript.foodInPan))
        {
            _eggsAndBacon.transform.position  = panSlot.position;
        }
    }
}
