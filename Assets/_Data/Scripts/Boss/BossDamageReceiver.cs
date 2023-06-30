using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamageReceiver : DamageReceiver
{
    [SerializeField] Animator animator;
    bool deathAnimation = false;
    public override void DeductHP(int damage)
    {
        base.DeductHP(damage);
        animator.SetTrigger("BossHit");

    }
    protected override void DestroyObject()
    {   if (deathAnimation != false) return;
        animator.SetTrigger("IsDeath");
        deathAnimation = true;
    }
    //animation envent
    protected virtual void DisableObject()
    {
        gameObject.SetActive(false);
        EnemySpawner.Instance.Despawn(transform);
    }
}
