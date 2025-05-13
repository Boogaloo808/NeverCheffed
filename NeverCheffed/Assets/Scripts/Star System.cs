using UnityEngine;

public class StarSystem : MonoBehaviour
{
    public Animator star;
    public starManager SM;
    

    void Start()
    {
        star = GetComponent<Animator>();
    }

    void Update()
    {
        var starValue = SM.starVal;
        star.SetFloat("starValue", starValue);

    }
}
