using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointFlow : TargetPlayer
{
    protected override void Reset()
    {
        this.ResetSpeed();
    }
    protected override void ResetSpeed()
    {
        this.speed = 1;
    }
    protected override void GoTaget()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, Player.transform.position, speed);
        transform.position = newPos;
    }
}
