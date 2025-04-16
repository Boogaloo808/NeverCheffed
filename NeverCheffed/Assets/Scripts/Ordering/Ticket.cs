using UnityEngine;

public class Ticket : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("OTT").transform, false);
    }
}
