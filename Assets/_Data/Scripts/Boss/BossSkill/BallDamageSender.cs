using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDamageSender : DamageSender
{
    protected override void ResetDamage()
    {
        this.damage = 10;
    }

}
