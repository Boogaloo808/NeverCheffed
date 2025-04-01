using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    FoodList FoodList;
    PanScript panScript;

    public List<String> eggsAndBacon;
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
            RecipeList(panScript.foodInPan);
        }
    }

    void RecipeList(List<GameObject> goList)
    {
        List<String> panList = new List<String>();

        for(int i = 0; i < goList.Count; i++)
        {
            panList.Add(goList[i].name);
        }


        if (eggsAndBacon == panList)
        {
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);
        }
    }
}
    