using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHeartBar :HeartBar
{
    [SerializeField] protected GameObject tranform;
    protected override void  FixedUpdate()
    {
        base.FixedUpdate();
        this.HeartBarRotatison();
    }
    protected virtual void HeartBarRotatison()
    {
        transform.rotation = tranform.transform.rotation;

    }
}
