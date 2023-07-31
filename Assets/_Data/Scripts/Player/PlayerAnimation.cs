using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : RootMonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected Animator animator;
    [SerializeField] protected SpriteRenderer sprite;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAnimator();
        this.LoadSprite();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (playerCtrl != null) return;
        this.playerCtrl = transform.GetComponentInParent<PlayerCtrl>();
        Debug.Log(transform.name + "Load PlayerCtrl", gameObject);
    }

    protected virtual void LoadAnimator()
    {
        if (this.animator != null) return;
        animator = transform.GetComponent<Animator>();
        Debug.Log(transform.name + " Load Animator", gameObject);
    }
    protected virtual void LoadSprite()
    {
        if (this.sprite != null) return;
        sprite = transform.GetComponent<SpriteRenderer>();
        Debug.Log(transform.name + " Load SpireRenderer", gameObject);
    }
    private void Update()
    {
        this.SetAnimator();
    }
    protected virtual void SetAnimator()
    {
        this.SetMove();
        this.SetAtack();
        this.SetFlix();
    }
    protected virtual void SetAtack()
    {
      
            if (InputManager.Instance.Fire == 1)
            {
                animator.SetBool("IsAtack", true);
            }
        else animator.SetBool("IsAtack", false);
    }

    protected virtual void SetMove()
    {
       
            if (InputManager.Instance.X != 0 || InputManager.Instance.Y != 0)
            {
                animator.SetFloat("X", InputManager.Instance.X);
                animator.SetFloat("Y", InputManager.Instance.Y);
                animator.SetBool("IsWalking", true);
            }
        else animator.SetBool("IsWalking", false);
    }
        
    protected virtual void SetFlix()
    {
        if (InputManager.Instance.X < 0) sprite.flipX = true;
        if (InputManager.Instance.X > 0) sprite.flipX = false;
    }

    

}
