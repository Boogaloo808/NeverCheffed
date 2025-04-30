using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class ActivatedAlarm : MonoBehaviour
{
    FallingFood FFood;
    FoodList foodlist;
    PlayerController player;

    [SerializeField] private Image activatedAlarm;
    public Color activeColor;
    public Color unactiveColor;

    void Start()
    {
        FFood = GameObject.Find("Spawner fridge").GetComponent<FallingFood>();
        activatedAlarm.color = activeColor;
    }
    void Update()
    {
        if (FFood.foodFalling)
        {
            activatedAlarm.color = activeColor;
        }
        else
        {
            activatedAlarm.color = unactiveColor;
        }
    }
}
