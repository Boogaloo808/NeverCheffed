using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    private void Start()
    {
        animator.SetBool("walkingR", false);
        animator.SetBool("walkingL", false);
        animator.SetBool("facing direction", true);
    }

    public void Update()
    {
        animator.SetFloat("speed", rb.velocity.magnitude / 5);
        

        if (rb.velocity.x > 0.05f)
        {
            transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
            animator.SetBool("walkingR", true);
            animator.SetBool("facing direction", true);
        }
        else
        {
            animator.SetBool("walkingR", false);
        }

        if (rb.velocity.x < -0.05f)
        {
            transform.localScale = new Vector3(-2.3f, 2.3f, 2.3f);
            animator.SetBool("walkingL", true);
            animator.SetBool("facing direction", false);
        }
        else
        {
            animator.SetBool("walkingL", false);
        }

    }
}
