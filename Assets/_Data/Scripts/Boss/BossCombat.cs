using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCombat : RootMonoBehaviour
{
   [SerializeField] protected BossDamageSender damageSender;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        damageSender.Send(collision.transform);
    }
    private void OnEnable()
    {
        GameManager.PlayerDied += DisableObject;
    }
    private void OnDisable()
    {
        GameManager.PlayerDied -= DisableObject;

    }
    protected virtual void DisableObject()
    {
        transform.gameObject.SetActive(false);
    }


}
