﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiverPlayer : DamageReceiver
{
    [SerializeField] protected Animator animator;
    protected bool deadAnimation = false;


    public override void DeductHP(int damage)
    {
        base.DeductHP(damage);
        if (IsDeath()) return;
        animator.SetTrigger("Hit");

    }
    protected override void DestroyObject()
    {
        if (!this.deadAnimation)
        {
            animator.SetTrigger("IsDeath");
            this.deadAnimation = true;
        }        
    }
        
    private void OnEnable()
    {
        GameManager.PlayerDied += DisablePlayer;
    }
    private void OnDisable()
    {
        GameManager.PlayerDied -= DisablePlayer;
    }



    protected virtual void DisablePlayer()
    {
        gameObject.SetActive(false);
    }
    

}
