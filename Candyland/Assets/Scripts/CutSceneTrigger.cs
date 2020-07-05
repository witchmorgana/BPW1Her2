using UnityEngine;

public class CutSceneTrigger : MonoBehaviour
{

    public Animator animator;
    private void OnCollisionEnter(Collision CollisionInfo)
    {

        if (CollisionInfo.collider.tag == "Player")
        {
            animator.SetBool("trigger", true);

        }
    }
}
