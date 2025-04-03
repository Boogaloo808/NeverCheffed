using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FoodCount : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CheeseText;

    public int CheeseNumber = 0;

    void Update()
    {
        CheeseText.text = CheeseNumber + " POINTS";
    }
}
