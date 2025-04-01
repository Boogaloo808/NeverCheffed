using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public List<GameObject> foodInPan;
    public Transform FFT;

    public Collider2D panCollider;

    public GameManager manager;

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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Food") && manager.Cooked)
        {
            Destroy(collision.gameObject);
        }
    }
}
