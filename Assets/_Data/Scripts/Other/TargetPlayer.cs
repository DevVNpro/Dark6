using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TargetPlayer : RootMonoBehaviour
{
    [SerializeField] protected GameObject Player;
   [SerializeField] protected float speed = 0.1f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTargetPlayer();
    }
    protected virtual void LoadTargetPlayer()
    {
        if (Player != null) return;
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
        this.GoTaget();
    }
    protected abstract void GoTaget();
    protected abstract void ResetSpeed();

}
