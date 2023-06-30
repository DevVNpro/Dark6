using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStage1 : StateMachineBehaviour
{
   [SerializeField] protected BossDamageReceiver bossDamageReceiver;
    [SerializeField] protected GameObject Player;
    [SerializeField] protected Transform transform;
 
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bossDamageReceiver = animator.GetComponent<BossDamageReceiver>();
        Player = GameObject.FindGameObjectWithTag("Player");
        transform = animator.GetComponent<Transform>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.SetBossPosition();
        this.SetBossStage(animator);
    }
    protected virtual void SetBossPosition()
    {
        Vector3 targetPosition = new Vector3(Player.transform.position.x, Player.transform.position.y + 3f, 0f);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 3 * Time.deltaTime);
    }
    protected virtual void SetBossStage(Animator animator)
    {
        IHpBarInterface hpBarInterface = bossDamageReceiver.GetComponent<IHpBarInterface>();

        if (hpBarInterface.Hp() < 40)
        {
            bossDamageReceiver.hp = 50;
            animator.SetTrigger("ChangeStage");

        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        


    }

}
