using UnityEngine;


public class anime : MonoBehaviour
{
    public Animator anim;


    public void IsWalk()
    {
        anim.SetBool("isWalk", !anim.GetBool("isWalk"));
    }

    public void IsJump()
    {
        anim.SetTrigger("isJump");
    }

    public void IsDie()
    {
        anim.Play("die");
    }
}
