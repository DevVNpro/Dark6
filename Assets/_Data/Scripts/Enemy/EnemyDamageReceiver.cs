using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected Animator animator;
    protected  override void Awake()
    {
        base.Awake();
    }
    public override void DeductHP(int damage)
    {
        base.DeductHP(damage);
        animator.SetTrigger("Hit"); 
    }

    protected override void DestroyObject()
    {
        this.Reborn();
        animator.SetTrigger("IsDeath");
    }



}
