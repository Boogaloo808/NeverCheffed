using UnityEngine;
using UnityEngine.WSA;

public class FallingFood : MonoBehaviour
{
    FoodList foodlist;
    PlayerController player;
    private int rand;


    public bool spawned = false;

    void Start()
    {
        foodlist = GameObject.FindGameObjectWithTag("Food").GetComponent<FoodList>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Spawn()
    {
                rand = Random.Range(0, foodlist.ingredients.Length);
                Instantiate(foodlist.ingredients[rand], transform.position, foodlist.ingredients[rand].transform.rotation);
    }
    void Update()
    {
        if ((player.activated) && (spawned == false))
            Invoke("Spawn", 0.1f);
    } 
}
