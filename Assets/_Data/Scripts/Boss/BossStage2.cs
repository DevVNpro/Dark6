using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStage2 : StateMachineBehaviour
{
    [SerializeField] protected Transform player;
    [SerializeField] protected BossFlip bossFlip;
    [SerializeField] protected Transform transform;
    [SerializeField] protected BossDamageReceiver bossDamageReceiver;
    [SerializeField] protected Canvas canvasHeartbar;
    [SerializeField]protected GameObject canvasGameObject;
    protected float speed = 3f;
    protected  float attackDistance = 5f;
    protected int randomAttack;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bossFlip = animator.GetComponent<BossFlip>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform = animator.GetComponent<Transform>();
        bossDamageReceiver = animator.GetComponent<BossDamageReceiver>();
        randomAttack = Random.Range(1, 3);

        this.EnebleCanvas();

    }
    protected virtual void EnebleCanvas()
    {
        canvasGameObject = transform.Find("Canvas_Boss").gameObject;
        canvasHeartbar = canvasGameObject.GetComponent<Canvas>();
        canvasHeartbar.gameObject.SetActive(true);
    }
    

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       this. SetBossStage(animator);
        this.SetMoveAndAttack(animator);
     
       
    }
    protected virtual void SetBossStage(Animator animator)
    {
        IHpBarInterface hpBarInterface = bossDamageReceiver.GetComponent<IHpBarInterface>();
        if (hpBarInterface.Hp() < 20) animator.SetTrigger("ChangeStage");
    }
    protected virtual void SetMoveAndAttack(Animator animator)
    {
        bossFlip.LookAtPlayer();
        // Tính toán vector hướng từ boss đến player
        Vector2 direction = player.position - transform.position;

        // Kiểm tra khoảng cách đến player
        float distance = direction.magnitude;

        if (distance > attackDistance)
        {


            // Tính toán vị trí mới để di chuyển tới player
            Vector3 targetPosition = player.position;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Di chuyển boss đến vị trí mới

        }
        else
        {
            // Boss đã ở trong khoảng tấn công, thực hiện hành động tấn công
            animator.SetInteger("Attack", randomAttack);
        }
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("Attack", 0);

    }


}
