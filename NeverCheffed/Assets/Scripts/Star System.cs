using UnityEngine;

public class StarSystem : MonoBehaviour
{
    public Animator star1, star2, star3, star4, star5;
    public starManager SM;

    void Start()
    {
        star1 = GetComponent<Animator>();
        star2 = GetComponent<Animator>();
        star3 = GetComponent<Animator>();
        star4 = GetComponent<Animator>();
        star5 = GetComponent<Animator>();
    }

    void Update()
    {
        star1.SetFloat("starValue", SM.starVal);
        star2.SetFloat("starValue", SM.starVal);
        star3.SetFloat("starValue", SM.starVal);
        star4.SetFloat("starValue", SM.starVal);
        star5.SetFloat("starValue", SM.starVal);
    }
}
