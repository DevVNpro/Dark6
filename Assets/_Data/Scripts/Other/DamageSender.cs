using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageSender : RootMonoBehaviour
{
    [SerializeField] protected int damage = 1;
    protected override void Awake()
    {
        base.Awake();
        this.ResetDamage();
    }
    public virtual void Send(Transform obj)
    {
         DamageReceiver damageReceiver = obj.GetComponent<DamageReceiver>();
        if (damageReceiver == null)
        {
            return;
        }
            
        this.Send(damageReceiver);
    }
    protected virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.DeductHP(this.damage);
    }


    protected abstract void ResetDamage();

}
