using UnityEngine;
using UnityEditor.UIElements;
using UnityEditor.UI;
using TMPro;

public class starManager : MonoBehaviour
{
    public float starVal = 0.5f;

    public GameObject win;

    private void Start()
    {
        starVal = 0.5f;
        win.SetActive(false);
    }

    private void Update()
    {
        if (starVal == 5f)
        {
            win.SetActive(true);
        }
    }

}