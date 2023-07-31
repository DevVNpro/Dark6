using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChangeStage : StateMachineBehaviour
{
    protected BoxCollider2D collider;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       collider = animator.GetComponent<BoxCollider2D>();
        collider.enabled = false;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        collider.enabled = true;

    }

}
