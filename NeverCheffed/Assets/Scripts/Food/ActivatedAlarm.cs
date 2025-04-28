using UnityEngine;

public class ActivatedAlarm : MonoBehaviour
{
    FallingFood FFood;
    FoodList foodlist;
    PlayerController player;

    public Material activeColor;
    public Material unactiveColor;
    MeshRenderer rend;

    void Start()
    {
        FFood = GetComponent<FallingFood>();
        foodlist = GameObject.FindGameObjectWithTag("list of food").GetComponent<FoodList>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rend = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if (FFood.foodFalling)
        {
            this.gameObject.GetComponent<SpriteRenderer>().material = activeColor;
        }
        if (FFood.foodFalling == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().material = unactiveColor;
        }
    }
}
