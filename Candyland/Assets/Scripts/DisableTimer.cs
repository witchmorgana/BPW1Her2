using UnityEngine;

public class DisableTimer : MonoBehaviour
{

    public Animator animator;
    private void OnCollisionEnter(Collision CollisionInfo)
    {

        if (CollisionInfo.collider.tag == "Player")
        {
            animator.SetBool("trigger2", true);

        }
    }
}
