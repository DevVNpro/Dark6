using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamageSender : DamageSender
{
    protected override void ResetDamage()
    {
        this.damage = 100;
    }
}
