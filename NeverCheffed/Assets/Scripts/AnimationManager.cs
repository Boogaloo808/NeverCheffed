using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    private void Start()
    {
        animator.SetBool("walkingR", false);
        animator.SetBool("walkingL", false);
    }

    public void Update()
    {
        animator.SetFloat("speed", rb.velocity.magnitude / 5);
        

        if (rb.velocity.x > 0.05f)
        {
            transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
            animator.SetBool("walkingR", true);
            Debug.Log("walking Right");
        }
        else
        {
            animator.SetBool("walkingR", false);
            Debug.Log("not walking Right");
        }

        if (rb.velocity.x < -0.05f)
        {
            transform.localScale = new Vector3(-2.3f, 2.3f, 2.3f);
            animator.SetBool("walkingL", true);
            Debug.Log("walking Left");
        }
        else
        {
            animator.SetBool("walkingL", false);
            Debug.Log("not Walking Left");
        }

    }
}
