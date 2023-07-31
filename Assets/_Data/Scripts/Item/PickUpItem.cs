using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : RootMonoBehaviour
{

    [SerializeField] protected DamageReceiverPlayer damageReceiverPlayer;
    [SerializeField] protected Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        damageReceiverPlayer.AddHp(100);
        animator.SetTrigger("Pick");
        SoundManager.Instance.PlayVFXmusic("Item");
        gameObject.SetActive(false);
        
    }
}
