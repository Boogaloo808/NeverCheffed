using System.Collections.Generic;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public List<GameObject> foodInPan;

    void Start()
    {
        foodInPan = new List<GameObject>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Food")) collision.gameObject.transform.SetParent(gameObject.transform, true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food")) foodInPan.Add(collision.gameObject);
    }


}
