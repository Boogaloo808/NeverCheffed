using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class FallingFood : MonoBehaviour
{
    FoodList foodlist;
    PlayerController player;
    private int rand;
    bool wait;
    public Collider2D roomCollider;

    bool playerInRoom = false;
    public bool spawned = false;

    void Start()
    {
        foodlist = GameObject.FindGameObjectWithTag("Food").GetComponent<FoodList>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Spawn()
    {
        wait = true;
        StartCoroutine("SpawnTime", 0);
    }
    void Update()
    {
        

        if ((player.activated) && (spawned == false) && !wait)
            Invoke("Spawn", 0f);
    } 

    IEnumerator SpawnTime(float seconds)
    {
        rand = Random.Range(0, foodlist.ingredients.Length);
        Instantiate(foodlist.ingredients[rand], transform.position + Vector3.right * Random.Range(-10, 10f), foodlist.ingredients[rand].transform.rotation);
        yield return new WaitForSeconds(0.6f);
        wait = false;
    }
}
