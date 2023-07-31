using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadLogic : MonoBehaviour
{
    //animation event
    protected virtual void PlayerDeathEvent()
    {
        GameManager.Instance.PlayerDeath();
    }

}
