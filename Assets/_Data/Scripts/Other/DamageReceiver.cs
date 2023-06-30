using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageReceiver : RootMonoBehaviour,IHpBarInterface
{
    public int hp ;
    [SerializeField] protected int hpMax;
    public int Hp()
    {
        return this.hp;
    }
    private void Update()
    {
        if(IsDeath()) this.DestroyObject();
    }


    protected override void Awake()
    {
        base.Awake();
        this.Reborn();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
    }
 
    public virtual void Reborn()
    {
        this.hp = this.hpMax;
    }

    public virtual void DeductHP(int damage)
    {
        if (IsDeath()) return;
        this.hp -= damage;
    }
    public virtual void AddHp(int hp)
    {
        if (this.hp >= this.hpMax) return;
        this.hp += hp;
        if (this.hp > this.hpMax)
        {
            int redundant  =   this.hp - this.hpMax;
            this.hp -= hp;
            this.hp += hp - redundant;
        }


    }
    protected virtual bool IsDeath()
    {
        return this.hp <= 0;
    }
    protected abstract void DestroyObject();

 


}





