using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerCtrl.DamageSender.Send(collision.transform);
        SoundManager.Instance.PlayVFXmusic("Attack");
    }
}
