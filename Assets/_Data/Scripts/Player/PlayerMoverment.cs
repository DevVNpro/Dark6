using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverment : RootMonoBehaviour
{
    [SerializeField] protected float speed = 5;
    private void FixedUpdate()
    {
        this.MovePlayer();
    }   
    protected virtual void MovePlayer() {
        transform.parent.position += new Vector3(InputManager.Instance.X * speed, InputManager.Instance.Y * speed, transform.parent.position.z) * Time.fixedDeltaTime;
    }

}
