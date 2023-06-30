using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : RootMonoBehaviour
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender => damageSender;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageSender();
    }
    protected virtual void LoadDamageSender()
    {
        if (damageSender != null) return;
        this.damageSender = transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.gameObject +"Load DamageSender", gameObject);
    }
}
