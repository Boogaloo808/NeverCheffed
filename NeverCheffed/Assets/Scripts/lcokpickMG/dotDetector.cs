using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotDetector : MonoBehaviour
{

    GameObject currentDot;
    void OnTriggerEnter2D(Collider2D other)
    {
        currentDot = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        currentDot = null;
    }

    private void Update()
    {
        
    }
}
