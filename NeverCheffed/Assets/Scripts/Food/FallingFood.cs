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

    public int foodCategory;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "Player")
            {
                playerInRoom = true;
            }
    }

    void Update()
    {

        if ((player.activated) && (spawned == false) && !wait && (playerInRoom))
            Invoke("Spawn", 0f);
    } 

    IEnumerator SpawnTime(float seconds)
    {
        if (foodCategory == 1)
        {
            rand = Random.Range(0, foodlist.fridgeRoom.Length);
            Instantiate(foodlist.fridgeRoom[rand], transform.position + Vector3.right * Random.Range(-10, 10f), foodlist.fridgeRoom[rand].transform.rotation);
        }
        else if (foodCategory == 2)
        {
            rand = Random.Range(0, foodlist.freezerRoom.Length);
            Instantiate(foodlist.freezerRoom[rand], transform.position + Vector3.right * Random.Range(-10, 10f), foodlist.freezerRoom[rand].transform.rotation);
        }
        else if (foodCategory == 3)
        {
            rand = Random.Range(0, foodlist.pantryRoom.Length);
            Instantiate(foodlist.pantryRoom[rand], transform.position + Vector3.right * Random.Range(-10, 10f), foodlist.pantryRoom[rand].transform.rotation);
        }
        else if (foodCategory == 4)
        {
            rand = Random.Range(0, foodlist.freezerRoom.Length);
            Instantiate(foodlist.freezerRoom[rand], transform.position + Vector3.right * Random.Range(-10, 10f), foodlist.spiceRoom[rand].transform.rotation);
        }

        yield return new WaitForSeconds(0.6f);
        wait = false;
    }
}
