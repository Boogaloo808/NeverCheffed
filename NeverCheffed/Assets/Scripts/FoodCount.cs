using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FoodCount : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CheeseText;
    public TMPro.TextMeshProUGUI MilkText;
    public TMPro.TextMeshProUGUI MeatText;
    public TMPro.TextMeshProUGUI EggText;
    public TMPro.TextMeshProUGUI RiceText;
    public TMPro.TextMeshProUGUI FlourText;
    public TMPro.TextMeshProUGUI SpiceText;
    public TMPro.TextMeshProUGUI BreadText;

    public int CheeseNumber = 0;
    public int MilkNumber = 0;
    public int MeatNumber = 0;
    public int EggNumber = 0;
    public int RiceNumber = 0;
    public int FlourNumber = 0;
    public int SpiceNumber = 0;
    public int BreadNumber = 0;

    void Update()
    {
        CheeseText.text = CheeseNumber + " Cheese";
        MilkText.text = MilkNumber + " Milk";
        MeatText.text = MeatNumber + " Meat";
        EggText.text = EggNumber + " Egg";
        RiceText.text = RiceNumber + " Rice";
        FlourText.text = FlourNumber + " Flour";
        SpiceText.text = SpiceNumber + " Spice";
        BreadText.text = BreadNumber + " Bread";
    }
}
