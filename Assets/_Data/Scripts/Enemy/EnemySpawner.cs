using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spanwer
{
    private static EnemySpawner instance;
    public static EnemySpawner Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (EnemySpawner.instance != null) Debug.LogError("only 1 instance allow to exist");
        EnemySpawner.instance = this;
    }
    public virtual Transform SpawnLevel1Prefabs()
    {
        return this.prefabs[0];
    }
    public virtual Transform SpawnLevel2Prefabs()
    {
        return this.prefabs[1]; ;
    }
    public virtual Transform SpawnLevel3prefabs()
    {
           return this.prefabs[this.prefabs.Count-1];
    }

}
