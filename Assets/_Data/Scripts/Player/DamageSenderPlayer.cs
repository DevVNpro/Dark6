using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSenderPlayer : DamageSender
{

    protected override void ResetDamage()
    {
        this.damage = 2;
    }
}
