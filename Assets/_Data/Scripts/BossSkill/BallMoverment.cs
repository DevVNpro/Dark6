using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoverment : TargetPlayer
{
    void Update()
    {
        transform.Rotate(0, 0, 1.2f * 360 * Time.deltaTime);
    }
    protected override void GoTaget()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, Player.transform.position, speed);
        transform.position = newPos;
    }
    protected override void ResetSpeed() {
        this.speed = 0.05f;
    }

}
