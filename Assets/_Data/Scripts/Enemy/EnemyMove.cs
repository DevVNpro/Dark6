using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : TargetPlayer
{
 
    protected override void Reset()
    {
        base.Reset();
        this.ResetSpeed();
    }
    protected override void ResetSpeed()
    {
        this.speed = 0.02f;
    }
    protected override void GoTaget()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, Player.transform.position, speed);
        transform.parent.position = newPos;
    }



}
