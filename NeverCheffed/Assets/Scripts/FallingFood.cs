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
        foodlist = GameObject.FindGameObjectWithTag("food").GetComponent<FoodList>();
        player = GetComponent<PlayerController>();

        if (player.activated)
        {
            Invoke("Spawn", 0.1f);
        }
    }

    void Spawn()
    {
        if (spawned == false)
        {
            rand = Random.Range(0, foodlist.ingredients.Length);
            Instantiate(foodlist.ingredients[rand], transform.position, foodlist.ingredients[rand].transform.rotation);

            spawned = true;
        }
    }
    void Update()
    {

    } 
}
