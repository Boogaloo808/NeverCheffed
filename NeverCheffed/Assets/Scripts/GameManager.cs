using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    PanScript panScript;

    public List<String> eggsAndBacon;
    public GameObject _eggsAndBacon;
    public Transform panSlot;
    public PanScript pan;

    public bool Cooked = false;

    void Start()
    {
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
            Instantiate(_eggsAndBacon, panSlot.transform.position, _eggsAndBacon.transform.rotation);
    }
}
    