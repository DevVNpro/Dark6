using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogicAnimation : MonoBehaviour
{
    //animation event
    protected void DespawnObject()
    {
        EnemySpawner.Instance.Despawn(transform.parent);
    }
}
